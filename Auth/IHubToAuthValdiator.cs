using System.Threading.Tasks;

namespace HubTo.Abstraction.Auth
{
    public interface IHubToAuthValdiator
    {
        Task<HubToAuthResult> ValidateApiKeyAsync(string apiKey);
        Task<HubToAuthResult> ValidateBasicAsync(string username, string password);
    }
}
