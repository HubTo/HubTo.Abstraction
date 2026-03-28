using System.Collections.Generic;
using System.IO;

namespace HubTo.Abstraction.Models
{
    public sealed class PluginRequest
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public string NamespaceId { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Query { get; set; }
        public Stream Body { get; set; }

        public PluginRequest()
        {
            Headers = new Dictionary<string, string>();
            Query = new Dictionary<string, string>();
            Body = Stream.Null;
        }
    }
}
