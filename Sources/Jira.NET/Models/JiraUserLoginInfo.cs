using System;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraUserLoginInfo
    {
        [DeserializeAs(Name = "failedLoginCount")]
        public int FailedLoginCount { get; set; }
        [DeserializeAs(Name = "loginCount")]
        public int LoginCount { get; set; }
        [DeserializeAs(Name = "lastFailedLoginTime")]
        public DateTime? LastFailedLoginTime { get; set; }
        [DeserializeAs(Name = "previousLoginTime")]
        public DateTime? PreviousLoginTime { get; set; }
    }
}
