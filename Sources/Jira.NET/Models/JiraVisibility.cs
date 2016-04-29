using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraVisibility
    {
        [DeserializeAs(Name = "expand")]
        public string Type { get; set; }

        [DeserializeAs(Name = "expand")]
        public string Value { get; set; }
    }
}
