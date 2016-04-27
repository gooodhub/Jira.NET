using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraUserSession
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}
