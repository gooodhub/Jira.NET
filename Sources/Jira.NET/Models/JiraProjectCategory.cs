using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraProjectCategory
    {
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "description")]
        public string Description { get; set; }
    }
}
