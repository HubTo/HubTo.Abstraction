using System.Collections.Generic;

namespace HubTo.Abstraction.Models.Storage
{
    public sealed class StorageMetadata
    {
        public string ContentType { get; set; }
        public IDictionary<string, string> Tags { get; set; }
    }
}
