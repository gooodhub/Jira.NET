using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraObject
    {
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "expand")]
        public string Expand { get; set; }
    }
}
