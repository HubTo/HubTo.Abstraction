using HubTo.Abstraction.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IHubToPlugin
    {
        string Name { get; }
        Task InitializeAsync(IDictionary<string, string> settings, IHubToLogger logger, CancellationToken cancellationToken = default);
        bool CanHandle(string path, string method);
        Task ShutdownAsync(CancellationToken ct = default);
    }
}
