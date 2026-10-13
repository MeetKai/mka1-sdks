namespace MeetKai.MKA1.Hooks
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    /// <summary>
    /// Fixes two issues with .NET's default multipart/form-data serialization:
    ///
    /// 1. Unquoted Content-Disposition field names — .NET 5+ omits quotes around
    ///    name/filename parameters (e.g. name=file instead of name="file").
    ///    Some servers require RFC 2046 quoted-string format to parse fields correctly.
    ///
    /// 2. Missing audio MIME types — the generated GetMimeType() only covers common
    ///    document/image types. Audio files (.wav, .mp3, .m4a, etc.) are sent as
    ///    application/octet-stream, which the transcription API rejects.
    /// </summary>
    internal class MultipartFixHook : IBeforeRequestHook
    {
        private static readonly Dictionary<string, string> AudioMimeTypes = new()
        {
            { ".wav", "audio/wav" },
            { ".mp3", "audio/mp3" },
            { ".m4a", "audio/x-m4a" },
            { ".mp4", "video/mp4" },
            { ".mpeg", "audio/mpeg" },
            { ".mpga", "audio/mpeg" },
            { ".ogg", "audio/ogg" },
            { ".flac", "audio/flac" },
            { ".webm", "audio/webm" },
        };

        public Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            if (request.Content is MultipartFormDataContent multipart)
            {
                foreach (var part in multipart)
                {
                    var disposition = part.Headers.ContentDisposition;
                    if (disposition == null)
                        continue;

                    // Fix 1: Quote field names and filenames
                    if (disposition.Name != null && !disposition.Name.StartsWith("\""))
                        disposition.Name = $"\"{disposition.Name}\"";

                    if (disposition.FileName != null && !disposition.FileName.StartsWith("\""))
                        disposition.FileName = $"\"{disposition.FileName}\"";

                    // Fix 2: Replace application/octet-stream with correct audio MIME type
                    if (disposition.FileName != null &&
                        part.Headers.ContentType?.MediaType == "application/octet-stream")
                    {
                        var fileName = disposition.FileName.Trim('"');
                        var ext = System.IO.Path.GetExtension(fileName)?.ToLowerInvariant();
                        if (ext != null && AudioMimeTypes.TryGetValue(ext, out var mimeType))
                        {
                            part.Headers.ContentType = new MediaTypeHeaderValue(mimeType);
                        }
                    }
                }
            }

            return Task.FromResult(request);
        }
    }
}
