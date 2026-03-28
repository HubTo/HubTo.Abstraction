using HubTo.Abstraction.Models;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IStoragePlugin : IHubToPlugin
    {
        Task<string> SaveAsync(Stream stream, string fileName, StorageMetadata metadata = null, CancellationToken cancellationToken = default);
        Task<Stream> GetAsync(string fileId, CancellationToken cancellationToken = default);
        Task DeleteAsync(string fileId, CancellationToken cancellationToken = default);
        Task<string?> GetDownloadUrlAsync(string fileId, TimeSpan expires, CancellationToken cancellationToken = default);
    }
}
