using System.Configuration;
using Jira.NET.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jira.NET.Tests
{
    [TestClass]
    public class JiraBasicRestClientTests
    {
        private static readonly string JiraTestUrl = ConfigurationManager.AppSettings["jira:test:url"];
        private static readonly string JiraTestUser = ConfigurationManager.AppSettings["jira:test:user"];
        private static readonly string JiraTestPassword = ConfigurationManager.AppSettings["jira:test:password"];

        [TestMethod]
        public void JiraBasicRestClient_Ctor_IsAuthenticated()
        {
            JiraBasicRestClient client = new JiraBasicRestClient(JiraTestUrl, JiraTestUser, JiraTestPassword);
            Assert.IsTrue(client.IsAuthenticated);
        }

        [TestMethod]
        public void JiraBasicRestClient_GetCurrentUser()
        {
            JiraBasicRestClient client = new JiraBasicRestClient(JiraTestUrl, JiraTestUser, JiraTestPassword);
            JiraUser currentUser = client.GetCurrentUser();
            Assert.IsNotNull(currentUser);
            Assert.AreEqual(JiraTestUser, currentUser.Name);
            Assert.IsNotNull(currentUser.AvatarUrls);
            Assert.IsNotNull(currentUser.Groups);
            Assert.IsNotNull(currentUser.ApplicationRoles);
            Assert.IsNotNull(currentUser.Groups.Items);
            Assert.IsNotNull(currentUser.ApplicationRoles.Items);
        }
    }
}
