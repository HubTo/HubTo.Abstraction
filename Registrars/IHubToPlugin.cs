using System.Collections.Generic;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Registrars
{
    public interface IHubToPlugin
    {
        string Name { get; }
        Task InitializeAsync(IDictionary<string, string> settings);
        bool CanHandle(string path, string method);
    }
}
