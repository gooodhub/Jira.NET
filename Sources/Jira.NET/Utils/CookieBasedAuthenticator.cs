using System;
using RestSharp;
using RestSharp.Authenticators;

namespace Jira.NET.Utils
{
    public class CookieBasedAuthenticator : IAuthenticator
    {
        private readonly string _authHeader;

        public CookieBasedAuthenticator(string cookieName, string cookieValue)
        {
            _authHeader = $"{cookieName}={cookieValue}";
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            if (request.Parameters.Exists(p => p.Name.Equals("Cookie", StringComparison.InvariantCultureIgnoreCase)))
                return;

            request.AddParameter("cookie", _authHeader, ParameterType.HttpHeader);
        }
    }
}
