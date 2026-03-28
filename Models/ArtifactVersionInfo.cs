using System;

namespace HubTo.Abstraction.Models
{
    public sealed class ArtifactVersionInfo
    {
        public Guid Id { get; set; }
        public string Version { get; set; }
        public string StoragePath { get; set; }
        public string Digest { get; set; }
        public string MediaType { get; set; }
        public long? SizeInBytes { get; set; }
        public bool IsListed { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
