using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraAvatarUrls
    {
        [DeserializeAs(Name = "16x16")]
        public string Small { get; set; }

        [DeserializeAs(Name = "24x24")]
        public string Medium { get; set; }

        [DeserializeAs(Name = "32x32")]
        public string Large { get; set; }

        [DeserializeAs(Name = "48x48")]
        public string ExtraLarge { get; set; }
    }
}