using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IStoragePlugin : IHubToPlugin
    {
        Task<string> SaveAsync(Stream stream, string fileName, CancellationToken ct = default);

        Task<Stream> GetAsync(string fileId, CancellationToken ct = default);

        Task DeleteAsync(string fileId, CancellationToken ct = default);

        Task<string?> GetDownloadUrlAsync(string fileId, TimeSpan expires, CancellationToken ct = default);
    }
}
