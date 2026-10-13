namespace MeetKai.MKA1.Hooks
{
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Flattens the "additionalProperties" dictionary into the parent JSON object
    /// for agent run request inputs.
    ///
    /// The generated SDK serializes CreateAgentRunRequestInput.AdditionalProperties
    /// with [JsonProperty("additionalProperties")], producing:
    ///   {"type": "text", "additionalProperties": {"text": "..."}}
    ///
    /// The API expects the dictionary entries merged into the parent object:
    ///   {"type": "text", "text": "..."}
    ///
    /// This hook detects the nested "additionalProperties" key inside "input" arrays
    /// for agent run requests and flattens the entries into each parent object.
    /// </summary>
    internal class AdditionalPropertiesFlattenHook : IBeforeRequestHook
    {
        public async Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            if (request.Content is not StringContent stringContent)
                return request;

            var mediaType = stringContent.Headers.ContentType?.MediaType;
            if (mediaType != "application/json")
                return request;

            var json = await stringContent.ReadAsStringAsync();
            JToken token;
            try
            {
                token = JToken.Parse(json);
            }
            catch (JsonReaderException)
            {
                return request;
            }

            if (token is not JObject root)
                return request;

            bool modified = false;

            // Flatten additionalProperties in "input" array items (agent runs)
            if (root["input"] is JArray inputArray)
            {
                foreach (var item in inputArray)
                {
                    if (item is JObject obj)
                        modified |= FlattenAdditionalProperties(obj);
                }
            }

            // Also handle top-level additionalProperties
            modified |= FlattenAdditionalProperties(root);

            if (!modified)
                return request;

            var cleaned = root.ToString(Formatting.None);
            var newContent = new StringContent(cleaned, Encoding.UTF8, "application/json");

            foreach (var header in stringContent.Headers)
            {
                if (header.Key != "Content-Type" && header.Key != "Content-Length")
                    newContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            request.Content = newContent;
            return request;
        }

        /// <summary>
        /// If the object has an "additionalProperties" key whose value is a JSON object,
        /// merge that object's entries into the parent and remove the key.
        /// Returns true if the object was modified.
        /// </summary>
        private static bool FlattenAdditionalProperties(JObject obj)
        {
            var ap = obj["additionalProperties"];
            if (ap is not JObject apObj)
                return false;

            obj.Remove("additionalProperties");
            foreach (var prop in apObj.Properties())
            {
                if (obj[prop.Name] == null)
                    obj[prop.Name] = prop.Value;
            }
            return true;
        }
    }
}
