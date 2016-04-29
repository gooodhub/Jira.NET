using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraIssue
    {
        [DeserializeAs(Name = "expand")]
        public string Expand { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "fields")]
        public JiraFields Fields { get; set; }

        [DeserializeAs(Name = "names")]
        public JiraFields Names { get; set; }

        [DeserializeAs(Name = "schema")]
        public JiraSchema Schema { get; set; }
    }
}
