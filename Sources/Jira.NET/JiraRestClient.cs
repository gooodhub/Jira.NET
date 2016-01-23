using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.NET
{
    public class JiraRestClient
    {
        private string ApiUrl = "jira/rest/api/2/";
        public Uri ServerUrl { get; }
        public Uri BaseUrl => new Uri(ServerUrl, ApiUrl);

        public JiraRestClient(string serverUrl)
        {
            if (string.IsNullOrWhiteSpace(serverUrl))
                throw new ArgumentNullException(nameof(serverUrl));
            Uri result;
            if (!Uri.TryCreate(serverUrl, UriKind.Absolute, out result))
                throw new FormatException("The server url provided is not a valid URI.");
            ServerUrl = result;
        }

        public JiraRestClient(Uri serverUrl)
        {
            if (serverUrl == null)
                throw new ArgumentNullException(nameof(serverUrl));

            ServerUrl = serverUrl;
        }
    }
}
