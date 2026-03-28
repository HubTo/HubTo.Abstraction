using HubTo.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IArtifactRegistry
    {
        Task<IEnumerable<ArtifactInfo>> GetArtifactsAsync(Guid namespaceId, CancellationToken cancellationToken = default);
        Task<IEnumerable<ArtifactVersionInfo>> GetVersionsAsync(Guid artifactId, CancellationToken cancellationToken = default);
        Task RegisterAsync(Guid namespaceId, string artifactName, ArtifactVersionInfo versionInfo, CancellationToken cancellationToken = default);
    }
}
