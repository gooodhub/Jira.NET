using System;
using System.Net;
using Jira.NET.Models;
using RestSharp;
using RestSharp.Serializers;

namespace Jira.NET
{
    public class JiraRestClient
    {
        private string ApiUrl = "rest/api/latest/";
        public Uri ServerUrl { get; }
        public Uri BaseUrl => new Uri(ServerUrl, ApiUrl);

        public virtual bool IsAuthenticated
        {
            get
            {
                IRestResponse restResponse = Execute("myself");
                return restResponse != null && restResponse.StatusCode == HttpStatusCode.OK && restResponse.ResponseStatus == ResponseStatus.Completed;
            }
        }

        protected IRestClient RestClient;

        public JiraRestClient(string serverUrl)
        {
            if (string.IsNullOrWhiteSpace(serverUrl))
                throw new ArgumentNullException(nameof(serverUrl));
            Uri result;
            if (!Uri.TryCreate(serverUrl, UriKind.Absolute, out result))
                throw new FormatException("The server url provided is not a valid URI, and has to be absolute.");
            ServerUrl = result;
            InitializeClient();
        }

        public JiraRestClient(Uri serverUrl)
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

        protected IRestResponse Execute(string request)
        {
            if (string.IsNullOrWhiteSpace(request))
                throw new ArgumentNullException(nameof(request));

            IRestRequest restRequest = new RestRequest(request);
            return RestClient.Execute(restRequest);
        }

        protected IRestResponse<T> Execute<T>(string request, Method method = Method.GET) where T : new()
        {
            if (string.IsNullOrWhiteSpace(request))
                throw new ArgumentNullException(nameof(request));

            IRestRequest restRequest = new RestRequest(request, method);
            IRestResponse<T> response = RestClient.Execute<T>(restRequest);
            if (response.ResponseStatus != ResponseStatus.Completed)
                if (response.ErrorException != null && !string.IsNullOrWhiteSpace(response.ErrorMessage))
                    throw new Exception(response.ErrorMessage, response.ErrorException);
                else
                    throw new Exception("The request failed for unknown reason.");
            return response;
        }

        public JiraUser GetCurrentUser()
        {
            IRestResponse<JiraUser> response = Execute<JiraUser>("myself");
            return response.Data;
        }
    }
}
