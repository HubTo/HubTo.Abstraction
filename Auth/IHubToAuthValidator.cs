using System.Threading;
using System.Threading.Tasks;

namespace HubTo.Abstraction.Auth
{
    public interface IHubToAuthValidator
    {
        Task<HubToAuthResult> ValidateAsync(HubToAuthRequest request, CancellationToken cancellationToken = default);
    }
}
