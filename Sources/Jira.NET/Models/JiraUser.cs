using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraUser : JiraObject
    {
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "emailAddress")]
        public string EmailAddress { get; set; }

        [DeserializeAs(Name = "avatarUrls")]
        public JiraAvatarUrls AvatarUrls { get; set; }

        [DeserializeAs(Name = "displayName")]
        public string DisplayName { get; set; }

        [DeserializeAs(Name = "active")]
        public bool Active { get; set; }

        [DeserializeAs(Name = "timeZone")]
        public string TimeZone { get; set; }

        [DeserializeAs(Name = "locale")]
        public string Locale { get; set; }

        [DeserializeAs(Name = "groups")]
        public JiraUserGroups Groups { get; set; }

        [DeserializeAs(Name = "applicationRoles")]
        public JiraApplicationRoles ApplicationRoles { get; set; }
    }
}
