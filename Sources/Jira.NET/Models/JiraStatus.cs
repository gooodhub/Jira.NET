using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraStatus
    {
        [DeserializeAs(Name = "id")]
        public string IconUrl { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
    }
}
