using System;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraWorklog
    {

        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "author")]
        public JiraAuthor Author { get; set; }

        [DeserializeAs(Name = "updateAuthor")]
        public JiraAuthor UpdateAuthor { get; set; }

        [DeserializeAs(Name = "comment")]
        public string Comment { get; set; }

        [DeserializeAs(Name = "updated")]
        public DateTime Updated { get; set; }

        [DeserializeAs(Name = "visibility")]
        public JiraVisibility Visibility { get; set; }

        [DeserializeAs(Name = "started")]
        public DateTime Started { get; set; }

        [DeserializeAs(Name = "timeSpent")]
        public string TimeSpent { get; set; }

        [DeserializeAs(Name = "timeSpentSeconds")]
        public int TimeSpentSeconds { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [DeserializeAs(Name = "issueId")]
        public string IssueId { get; set; }
    }
}
