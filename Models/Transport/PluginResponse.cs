using System.Collections.Generic;
using System.IO;

namespace HubTo.Abstraction.Models.Transport
{
    public sealed class PluginResponse
    {
        public int StatusCode { get; set; }
        public string ContentType { get; set; }
        public object Content { get; set; }
        public Stream StreamContent { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public bool IsStream => StreamContent != null;

        public PluginResponse()
        {
            StatusCode = 200;
            ContentType = "application/json";
            Headers = new Dictionary<string, string>();
        }

        public static PluginResponse Json(object content, int statusCode = 200)
            => new PluginResponse { Content = content, StatusCode = statusCode, ContentType = "application/json" };

        public static PluginResponse Stream(Stream stream, string contentType, int statusCode = 200)
            => new PluginResponse { StreamContent = stream, ContentType = contentType, StatusCode = statusCode };

        public static PluginResponse Ok() => new PluginResponse { StatusCode = 200 };
        public static PluginResponse NotFound() => new PluginResponse { StatusCode = 404 };
    }

}
