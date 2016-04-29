using System;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraIssueLink
    {
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [DeserializeAs(Name = "type")]
        public Type Type { get; set; }

        [DeserializeAs(Name = "outwardIssue")]
        public JiraWardIssue OutwardIssue { get; set; }

        [DeserializeAs(Name = "inwardIssue")]
        public JiraWardIssue InwardIssue { get; set; }
    }
}
