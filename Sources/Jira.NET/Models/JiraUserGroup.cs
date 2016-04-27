using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraUserGroup : JiraObject
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "users")]
        public JiraExpandedObject<JiraUser> Users { get; set; }
    }
}
