using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraWatcher
    {
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "displayName")]
        public string DisplayName { get; set; }

        [DeserializeAs(Name = "active")]
        public bool Active { get; set; }
    }
}
