using System;

namespace Jira.NET.Tests.Mock
{
    public class JiraTestRestClient : JiraRestClient
    {
        public JiraTestRestClient(string serverUrl) : base(serverUrl)
        {
        }

        public JiraTestRestClient(Uri serverUrl) : base(serverUrl)
        {
        }

        public override bool IsAuthenticated { get; }
    }
}
