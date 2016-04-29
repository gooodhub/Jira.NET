using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraFields
    {
        [DeserializeAs(Name = "watcher")]
        public string Watcher { get; set; }

        [DeserializeAs(Name = "attachment")]
        public string Attachment { get; set; }

        [DeserializeAs(Name = "sub-tasks")]
        public string SubTasks { get; set; }

        [DeserializeAs(Name = "description")]
        public string Description { get; set; }

        [DeserializeAs(Name = "project")]
        public string Project { get; set; }

        [DeserializeAs(Name = "comment")]
        public string Comment { get; set; }

        [DeserializeAs(Name = "issuelinks")]
        public string Issuelinks { get; set; }

        [DeserializeAs(Name = "worklog")]
        public string Worklog { get; set; }

        [DeserializeAs(Name = "updated")]
        public string Updated { get; set; }

        [DeserializeAs(Name = "timetracking")]
        public string Timetracking { get; set; }
    }
}
