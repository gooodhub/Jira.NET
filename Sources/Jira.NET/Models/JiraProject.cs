using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraProject
    {
        public class Project
        {

            [DeserializeAs(Name = "self")]

            public string Self { get; set; }

            [DeserializeAs(Name = "id")]
            public string Id { get; set; }

            [DeserializeAs(Name = "key")]
            public string Key { get; set; }

            [DeserializeAs(Name = "name")]
            public string Name { get; set; }

            [DeserializeAs(Name = "jiraavatarurls")]
            public JiraAvatarUrls JiraAvatarUrls { get; set; }

            [DeserializeAs(Name = "projectcategory")]
            public JiraProjectCategory ProjectCategory { get; set; }
        }
    }
}
