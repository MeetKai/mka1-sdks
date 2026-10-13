namespace MeetKai.MKA1.Hooks
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Fixes deserialization failures for endpoints returning ItemListObject
    /// (conversations.items.create, conversations.items.list).
    ///
    /// Root cause: The generated ItemWithIdConverter tries OutputMessageWithId
    /// BEFORE InputMessageWithId. Both types share the same JSON field names,
    /// so OutputMessageWithId is attempted for user messages. Its content
    /// converter (OutputMessageWithIdContentConverter) is a discriminated union
    /// that only knows "output_text" and "refusal" — when it encounters
    /// "input_text", it throws InvalidOperationException, which is NOT caught
    /// by the union deserializer's exception handling chain (it only catches
    /// JsonSerializationException and DeserializationException). This crashes
    /// the entire deserialization.
    ///
    /// Fix: For non-assistant message items, this hook converts the content
    /// array to a plain string. This causes OutputMessageWithId deserialization
    /// to fail cleanly (can't deserialize a string as List — throws
    /// JsonSerializationException which IS properly handled), and
    /// InputMessageWithId succeeds because its content union natively supports
    /// both strings and arrays.
    ///
    /// Additionally strips unknown fields from items to handle API fields
    /// added after SDK generation.
    /// </summary>
    internal class ItemListResponseFixHook : IAfterSuccessHook
    {
        private static readonly HashSet<string> TargetOperations = new()
        {
            "conversations.items.create",
            "conversations.items.list",
        };

        private static readonly HashSet<string> NonAssistantRoles = new()
        {
            "user", "system", "developer",
        };

        // Known fields per item type value. Built from the generated model classes.
        private static readonly Dictionary<string, HashSet<string>> KnownFieldsByType = new()
        {
            ["message"] = new HashSet<string>
            {
                "type", "id", "role", "content", "status", "response_id", "metadata"
            },
            ["file_search_call"] = new HashSet<string>
            {
                "type", "id", "status", "queries", "results", "response_id", "metadata"
            },
            ["computer_call"] = new HashSet<string>
            {
                "type", "id", "call_id", "action", "pending_safety_checks", "status", "response_id", "metadata"
            },
            ["computer_call_output"] = new HashSet<string>
            {
                "type", "id", "call_id", "output", "acknowledged_safety_checks", "response_id", "metadata"
            },
            ["web_search_call"] = new HashSet<string>
            {
                "type", "id", "status", "response_id", "metadata"
            },
            ["function_call"] = new HashSet<string>
            {
                "type", "id", "call_id", "name", "arguments", "status", "response_id", "metadata"
            },
            ["function_call_output"] = new HashSet<string>
            {
                "type", "id", "call_id", "output", "status", "response_id", "metadata"
            },
            ["reasoning"] = new HashSet<string>
            {
                "type", "id", "summary", "encrypted_content", "status", "response_id", "metadata"
            },
            ["image_generation_call"] = new HashSet<string>
            {
                "type", "id", "status", "result", "response_id", "metadata"
            },
            ["code_interpreter_call"] = new HashSet<string>
            {
                "type", "id", "status", "code", "results", "container_id", "response_id", "metadata"
            },
            ["local_shell_call"] = new HashSet<string>
            {
                "type", "id", "call_id", "action", "status", "response_id", "metadata"
            },
            ["local_shell_call_output"] = new HashSet<string>
            {
                "type", "id", "call_id", "output", "response_id", "metadata"
            },
            ["shell_call"] = new HashSet<string>
            {
                "type", "id", "call_id", "action", "status", "response_id", "metadata"
            },
            ["shell_call_output"] = new HashSet<string>
            {
                "type", "id", "call_id", "output", "response_id", "metadata"
            },
            ["mcp_list_tools"] = new HashSet<string>
            {
                "type", "id", "server_label", "tools", "error", "response_id", "metadata"
            },
            ["mcp_approval_request"] = new HashSet<string>
            {
                "type", "id", "server_label", "method", "params", "response_id", "metadata"
            },
            ["mcp_approval_response"] = new HashSet<string>
            {
                "type", "id", "approval_request_id", "approve", "reason", "response_id", "metadata"
            },
            ["mcp_call"] = new HashSet<string>
            {
                "type", "id", "server_label", "name", "arguments", "error", "output", "response_id", "metadata"
            },
            ["custom_tool_call"] = new HashSet<string>
            {
                "type", "id", "name", "arguments", "response_id", "metadata"
            },
            ["custom_tool_call_output"] = new HashSet<string>
            {
                "type", "id", "call_id", "output", "response_id", "metadata"
            },
            ["item_reference"] = new HashSet<string>
            {
                "type", "id", "response_id", "metadata"
            },
        };

        public async Task<HttpResponseMessage> AfterSuccessAsync(AfterSuccessContext hookCtx, HttpResponseMessage response)
        {
            if (!TargetOperations.Contains(hookCtx.OperationID))
                return response;

            var contentType = response.Content.Headers.ContentType?.MediaType;
            if (contentType != "application/json")
                return response;

            var body = await response.Content.ReadAsStringAsync();
            JToken token;
            try
            {
                token = JToken.Parse(body);
            }
            catch (JsonReaderException)
            {
                return response;
            }

            if (token is not JObject root || root["data"] is not JArray dataArray)
                return response;

            bool modified = false;
            foreach (var item in dataArray)
            {
                if (item is JObject itemObj)
                {
                    modified |= StripUnknownFields(itemObj);
                    modified |= FlattenNonAssistantContent(itemObj);
                }
            }

            if (!modified)
                return response;

            var cleaned = root.ToString(Formatting.None);
            var newContent = new StringContent(cleaned, Encoding.UTF8, "application/json");

            // Preserve original response headers on the new content
            foreach (var header in response.Content.Headers)
            {
                if (header.Key != "Content-Type" && header.Key != "Content-Length")
                    newContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            response.Content = newContent;
            return response;
        }

        /// <summary>
        /// For non-assistant message items, converts the content array to a
        /// plain string. This prevents the OutputMessageWithIdContentConverter
        /// from being triggered (it crashes on input_text/input_image/etc).
        ///
        /// InputMessageWithIdContent natively supports both strings and arrays,
        /// so the string form deserializes correctly.
        /// </summary>
        private static bool FlattenNonAssistantContent(JObject item)
        {
            var typeValue = item["type"]?.ToString();
            if (typeValue != "message")
                return false;

            var role = item["role"]?.ToString();
            if (role == null || !NonAssistantRoles.Contains(role))
                return false;

            if (item["content"] is not JArray contentArray)
                return false;

            // Extract text from input_text content items
            var texts = new List<string>();
            foreach (var contentItem in contentArray)
            {
                if (contentItem is JObject co && co["type"]?.ToString() == "input_text")
                {
                    var text = co["text"]?.ToString();
                    if (text != null)
                        texts.Add(text);
                }
            }

            if (texts.Count == 0)
                return false;

            item["content"] = string.Join("\n", texts);
            return true;
        }

        private static bool StripUnknownFields(JObject item)
        {
            var typeValue = item["type"]?.ToString();
            if (typeValue == null || !KnownFieldsByType.TryGetValue(typeValue, out var knownFields))
                return false;

            var toRemove = new List<string>();
            foreach (var prop in item.Properties())
            {
                if (!knownFields.Contains(prop.Name))
                    toRemove.Add(prop.Name);
            }

            foreach (var name in toRemove)
                item.Remove(name);

            return toRemove.Count > 0;
        }
    }
}
