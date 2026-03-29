using System;

namespace HubTo.Abstraction.Models.Domain
{
    public sealed class ArtifactVersionInfo
    {
        public Guid Id { get; set; }
        public Guid ArtifactId { get; set; }
        public string Version { get; set; }
        public string StoragePath { get; set; }
        public string Digest { get; set; }
        public string MediaType { get; set; }
        public long? SizeInBytes { get; set; }
        public bool IsListed { get; set; } = true;
        public DateTime PublishedAt { get; set; }
        public string ExtraMetadataJson { get; set; }
    }
}
