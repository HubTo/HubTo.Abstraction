using System;

namespace HubTo.Abstraction.Models
{
    public sealed class ArtifactInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RegistrarType { get; set; }
        public Guid NamespaceId { get; set; }
    }
}
