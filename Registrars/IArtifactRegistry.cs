using HubTo.Abstraction.Models.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IArtifactRegistry
    {
        string BaseUrl { get; }
        Task<ArtifactInfo?> GetArtifactAsync(Guid namespaceId, string artifactName, CancellationToken cancellationToken = default);
        Task<IEnumerable<ArtifactInfo>> GetArtifactsAsync(Guid namespaceId, CancellationToken cancellationToken = default);
        Task<IEnumerable<ArtifactInfo>> SearchAsync(Guid namespaceId, string query, int skip = 0, int take = 20, CancellationToken cancellationToken = default);
        Task<ArtifactInfo> EnsureArtifactAsync(Guid namespaceId, string artifactName, string registrarType, CancellationToken cancellationToken = default);
        Task<IEnumerable<ArtifactVersionInfo>> GetVersionsAsync(Guid artifactId, CancellationToken cancellationToken = default);
        Task<ArtifactVersionInfo?> GetVersionAsync(Guid artifactId, string version, CancellationToken cancellationToken = default);
        Task<ArtifactVersionInfo> AddVersionAsync(Guid artifactId, Stream stream, ArtifactVersionInfo versionInfo, CancellationToken cancellationToken = default);
        Task<Stream> GetVersionStreamAsync(Guid artifactId, string version, CancellationToken cancellationToken = default);
        Task UnlistVersionAsync(Guid artifactId, string version, CancellationToken cancellationToken = default);
    }
}
