using System;
using System.Net;
using System.Net.Http;
using Jira.NET.Models;
using RestSharp;

namespace Jira.NET
{
    public abstract class JiraRestClient
    {
        private string ApiUrl = "rest/api/latest/";
        public Uri ServerUrl { get; }
        public Uri BaseUrl => new Uri(ServerUrl, ApiUrl);

        public abstract bool IsAuthenticated { get; }

        protected IRestClient RestClient;

        protected JiraRestClient(string serverUrl)
        {
            if (string.IsNullOrWhiteSpace(serverUrl))
                throw new ArgumentNullException(nameof(serverUrl));
            Uri result;
            if (!Uri.TryCreate(serverUrl, UriKind.Absolute, out result))
                throw new FormatException("The server url provided is not a valid URI, and has to be absolute.");
            ServerUrl = result;
            InitializeClient();
        }

        protected JiraRestClient(Uri serverUrl)
        {
            if (serverUrl == null)
                throw new ArgumentNullException(nameof(serverUrl));
            if (!serverUrl.IsAbsoluteUri)
                throw new FormatException("The provided server url has to be absolute.");
            ServerUrl = serverUrl;
            InitializeClient();
        }

        private void InitializeClient()
        {
            RestClient = new RestClient(BaseUrl);
        }

        protected IRestResponse Execute(string request, Method method = Method.GET)
        {
            if (string.IsNullOrWhiteSpace(request))
                throw new ArgumentNullException(nameof(request));

            IRestRequest restRequest = new RestRequest(request);
            IRestResponse response = RestClient.Execute(restRequest);
            if (response.ResponseStatus != ResponseStatus.Completed)
                if (response.ErrorException != null && !string.IsNullOrWhiteSpace(response.ErrorMessage))
                    throw new HttpRequestException(response.ErrorMessage, response.ErrorException);
                else
                    throw new HttpRequestException("The request failed with the following response status '" + response.ResponseStatus + "' and status code '" + response.StatusCode + "'.");
            return response;
        }

        protected IRestResponse<T> Execute<T>(string request, Method method = Method.GET) where T : new()
        {
            if (string.IsNullOrWhiteSpace(request))
                throw new ArgumentNullException(nameof(request));

            IRestRequest restRequest = new RestRequest(request, method);
            IRestResponse<T> response = RestClient.Execute<T>(restRequest);
            if (response.ResponseStatus != ResponseStatus.Completed)
                if (response.ErrorException != null && !string.IsNullOrWhiteSpace(response.ErrorMessage))
                    throw new HttpRequestException(response.ErrorMessage, response.ErrorException);
                else
                    throw new HttpRequestException("The request failed with the following response status '" + response.ResponseStatus + "' and status code '" + response.StatusCode + "'.");
            return response;
        }

        public JiraUser GetCurrentUser()
        {
            IRestResponse<JiraUser> response = Execute<JiraUser>("myself");
            return response.Data;
        }

        public JiraWardIssue GetIssue(string key)
        {
            IRestResponse<JiraWardIssue> response = Execute<JiraWardIssue>("issue/" + key);
            return response.Data;
        }
    }
}
