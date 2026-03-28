using HubTo.Abstraction.Models;
using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IRegistrarPlugin : IHubToPlugin
    {
        string RegistrarType { get; }

        void SetContext(IArtifactRegistry artifactRegistry, IStoragePlugin storage);
        Task<PluginResponse> ProcessRequestAsync(PluginRequest request, CancellationToken cancellationToken = default);
        bool CanHandle(string path, string method);
    }
}
