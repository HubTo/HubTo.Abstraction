using System.Collections.Generic;

namespace HubTo.Abstraction.Models
{
    public sealed class StorageMetadata
    {
        public string ContentType { get; set; }
        public IDictionary<string, string> Tags { get; set; }
    }
}
