using HubTo.Abstraction.Enums;
using HubTo.Abstraction.Logging;
using HubTo.Abstraction.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IHubToPlugin
    {
        string Name { get; }
        PluginType Type { get; }
        Task InitializeAsync(IDictionary<string, string> settings, IHubToLogger logger, CancellationToken cancellationToken = default);
        Task ShutdownAsync(CancellationToken cancellationToken = default);
        Task<HealthStatus> CheckHealthAsync(CancellationToken cancellationToken = default);
    }
}
