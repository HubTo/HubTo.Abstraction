using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Auth
{
    public interface IHubToAuthValdiator
    {
        Task<HubToAuthResult> ValidateApiKeyAsync(string apiKey, CancellationToken cancellationToken = default);
        Task<HubToAuthResult> ValidateBasicAsync(string username, string password, CancellationToken cancellationToken = default);
    }
}
