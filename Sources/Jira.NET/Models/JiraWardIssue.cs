using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraWardIssue
    {
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "fields")]
        public JiraFields Fields { get; set; }
    }
}
