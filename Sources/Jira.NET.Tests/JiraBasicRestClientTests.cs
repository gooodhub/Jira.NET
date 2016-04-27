using Jira.NET.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jira.NET.Tests
{
    [TestClass]
    public class JiraBasicRestClientTests
    {
        [TestMethod]
        public void JiraBasicRestClient_Ctor_IsAuthenticated()
        {
            JiraBasicRestClient client = new JiraBasicRestClient("http://projects.goood.pro:8080", "dev", "P@ssw0rd");
            Assert.IsTrue(client.IsAuthenticated);
        }

        [TestMethod]
        public void JiraBasicRestClient_GetCurrentUser()
        {
            const string login = "dev";
            JiraBasicRestClient client = new JiraBasicRestClient("http://projects.goood.pro:8080", login, "P@ssw0rd");
            JiraUser currentUser = client.GetCurrentUser();
            Assert.IsNotNull(currentUser);
            Assert.AreEqual(login, currentUser.Name);
            Assert.IsNotNull(currentUser.AvatarUrls);
            Assert.IsNotNull(currentUser.Groups);
            Assert.IsNotNull(currentUser.ApplicationRoles);
            Assert.IsNotNull(currentUser.Groups.Items);
            Assert.IsNotNull(currentUser.ApplicationRoles.Items);
        }
    }
}
