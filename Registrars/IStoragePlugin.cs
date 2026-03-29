using HubTo.Abstraction.Models.PluginResult;
using HubTo.Abstraction.Models.Storage;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IStoragePlugin : IHubToPlugin
    {
        Task<PluginResult<string>> SaveAsync(Stream stream, string fileName, StorageMetadata metadata = null, CancellationToken cancellationToken = default);
        Task<PluginResult<Stream>> GetAsync(string fileId, CancellationToken cancellationToken = default);
        Task<PluginResult> DeleteAsync(string fileId, CancellationToken cancellationToken = default);
        Task<PluginResult<string>> GetDownloadUrlAsync(string fileId, TimeSpan expires, CancellationToken cancellationToken = default);
    }
}
