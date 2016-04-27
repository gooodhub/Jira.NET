using System;
using RestSharp;
using RestSharp.Authenticators;

namespace Jira.NET
{
    public class JiraBasicRestClient : JiraRestClient
    {
        public JiraBasicRestClient(string serverUrl, string login, string password) : base(serverUrl)
        {
            InitializeClient(login, password);
        }

        private void InitializeClient(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));

            RestClient.Authenticator = new HttpBasicAuthenticator(login, password);
        }

        public JiraBasicRestClient(Uri serverUrl, string login, string password) : base(serverUrl)
        {
            InitializeClient(login, password);
        }
    }
}
