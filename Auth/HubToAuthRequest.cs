using System.Collections.Generic;

namespace HubTo.Abstraction.Auth
{
    public class HubToAuthRequest
    {
        public string Scheme { get; }
        public IReadOnlyDictionary<string, string> Values { get; }

        public HubToAuthRequest(string scheme, IDictionary<string, string> values)
        {
            Scheme = scheme;
            Values = new Dictionary<string, string>(values);
        }
    }
}
