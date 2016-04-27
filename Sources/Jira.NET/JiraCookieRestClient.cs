using System;
using Jira.NET.Models;
using Jira.NET.Utils;
using RestSharp;

namespace Jira.NET
{
    public class JiraCookieRestClient : JiraRestClient
    {
        private string ApiAuthUrl = "rest/auth/latest/";
        public Uri BaseAuthUrl => new Uri(ServerUrl, ApiAuthUrl);

        private IRestClient _restAuthClient;

        public JiraCookieRestClient(string serverUrl, string cookieName = null, string cookieValue = null) : base(serverUrl)
        {
            InitializeAuthClient(cookieName, cookieValue);
        }

        public JiraCookieRestClient(Uri serverUrl, string cookieName = null, string cookieValue = null) : base(serverUrl)
        {
            InitializeAuthClient(cookieName, cookieValue);
        }

        private void InitializeAuthClient(string cookieName = null, string cookieValue = null)
        {
            _restAuthClient = new RestClient(BaseAuthUrl);
            if (!string.IsNullOrWhiteSpace(cookieName) && !string.IsNullOrWhiteSpace(cookieValue))
                InitializeAuthenticator(cookieName, cookieValue);
        }

        private void InitializeAuthenticator(string cookieName, string cookieValue)
        {
            _restAuthClient.Authenticator = new CookieBasedAuthenticator(cookieName, cookieValue);
            RestClient.Authenticator = new CookieBasedAuthenticator(cookieName, cookieValue);
        }

        public JiraUserLogin Login(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));

            IRestRequest request = new RestRequest("session", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new JiraUserAuthentication(login, password));
            IRestResponse<JiraUserLogin> response = _restAuthClient.Execute<JiraUserLogin>(request);
            JiraUserLogin jiraUserLogin = response.Data;
            InitializeAuthenticator(jiraUserLogin.Session.Name, jiraUserLogin.Session.Value);
            return jiraUserLogin;
        }

        // TODO : à finir
        public void Logout()
        {
            IRestRequest request = new RestRequest("session", Method.DELETE);
            IRestResponse response = _restAuthClient.Execute(request);
        }
    }
}
