using System;

namespace HubTo.Abstraction.Logging
{
    public interface IHubToLogger
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception ex = null);
    }
}
