﻿using System;
using Jira.NET.Tests.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jira.NET.Tests
{
    [TestClass]
    public class JiraRestClientTests
    {
        [TestMethod]
        public void JiraRestClient_Ctor_Uri_OK()
        {
            Uri serverUrl = new Uri("http://www.google.fr");
            JiraRestClient client = new JiraTestRestClient(serverUrl);
            Assert.IsNotNull(client);
            Assert.AreEqual(serverUrl, client.ServerUrl);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JiraRestClient_Ctor_Uri_Required()
        {
            JiraRestClient client = new JiraTestRestClient((Uri)null);
            Assert.IsNull(client);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void JiraRestClient_Ctor_Uri_NotAbsolute()
        {
            Uri serverUrl = new Uri("~/test/super.jpg", UriKind.Relative);
            JiraRestClient client = new JiraTestRestClient(serverUrl);
            Assert.IsNull(client);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JiraRestClient_Ctor_StringUri_Required()
        {
            JiraRestClient client = new JiraTestRestClient(string.Empty);
            Assert.IsNull(client);
        }

        [TestMethod]
        public void JiraRestClient_Ctor_StringUri_OK()
        {
            Uri serverUri = new Uri("http://www.google.fr");
            JiraRestClient client = new JiraTestRestClient("http://www.google.fr");
            Assert.IsNotNull(client);
            Assert.AreEqual(serverUri, client.ServerUrl);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void JiraRestClient_Ctor_StringUri_NotAbsolute()
        {
            JiraRestClient client = new JiraTestRestClient("/test/super.jpg");
            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void JiraRestClient_Ctor_BaseUrl_WellFormatted()
        {
            JiraRestClient client = new JiraTestRestClient("http://www.jira.com:8080/server");
            Assert.IsNotNull(client);
            // final Url used server Url base (without subfolder/virtual dir) combined with jira rest api path => subfolder/virtual dir are truncated
            Assert.AreEqual(new Uri("http://www.jira.com:8080/rest/api/latest/"), client.BaseUrl);
        }
    }
}
