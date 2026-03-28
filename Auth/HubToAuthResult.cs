namespace HubTo.Abstraction.Auth
{
    public class HubToAuthResult
    {
        public bool IsAuthenticated { get; }
        public string IdentityId { get; }
        public string ErrorMessage { get; }
        public string Scopes { get; }
        public string NamespaceId { get; }

        public HubToAuthResult(
            bool isAuthenticated,
            string identityId = null,
            string errorMessage = null,
            string scopes = null,
            string namespaceId = null)
        {
            IsAuthenticated = isAuthenticated;
            IdentityId = identityId;
            ErrorMessage = errorMessage;
            Scopes = scopes;
            NamespaceId = namespaceId;
        }

        public static HubToAuthResult Success(string identityId, string namespaceId, string scopes = null)
            => new HubToAuthResult(true, identityId, null, scopes, namespaceId);

        public static HubToAuthResult Failure(string errorMessage)
            => new HubToAuthResult(false, null, errorMessage, null, null);
    }
}
