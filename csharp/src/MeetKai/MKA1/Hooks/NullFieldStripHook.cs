namespace MeetKai.MKA1.Hooks
{
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Strips null-valued properties from JSON request bodies before sending.
    ///
    /// The generated SDK annotates several nullable fields (tool_choice, conversation,
    /// input, etc.) with NullValueHandling.Include, which serializes them as
    /// "field": null. The API rejects null for these fields — it expects either a
    /// valid value or for the field to be omitted entirely.
    ///
    /// This hook removes all null properties from the top-level JSON object so that
    /// unset optional fields are simply omitted from the request.
    /// </summary>
    internal class NullFieldStripHook : IBeforeRequestHook
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

            if (token is JObject obj)
            {
                RemoveNullProperties(obj);
                var cleaned = obj.ToString(Formatting.None);
                var newContent = new StringContent(cleaned, Encoding.UTF8, "application/json");

                // Preserve any extra headers from the original content
                foreach (var header in stringContent.Headers)
                {
                    if (header.Key != "Content-Type" && header.Key != "Content-Length")
                        newContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }

                request.Content = newContent;
            }

            return request;
        }

        private static void RemoveNullProperties(JObject obj)
        {
            var nullProps = new System.Collections.Generic.List<string>();
            foreach (var prop in obj.Properties())
            {
                if (prop.Value.Type == JTokenType.Null)
                    nullProps.Add(prop.Name);
                else if (prop.Value is JObject nested)
                    RemoveNullProperties(nested);
            }
            foreach (var name in nullProps)
                obj.Remove(name);
        }
    }
}
