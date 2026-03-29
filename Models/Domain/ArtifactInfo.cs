using System;
using System.Collections.Generic;

namespace HubTo.Abstraction.Models.Domain
{
    public sealed class ArtifactInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RegistrarType { get; set; }
        public Guid NamespaceId { get; set; }
        public string Description { get; set; }
        public string Authors { get; set; }
        public string LatestVersion { get; set; }
        public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
    }
}
