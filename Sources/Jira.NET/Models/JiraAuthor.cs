using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraAuthor
    {
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "avatarUrls")]
        public JiraAvatarUrls AvatarUrls { get; set; }

        [DeserializeAs(Name = "displayName")]
        public string DisplayName { get; set; }

        [DeserializeAs(Name = "active")]
        public bool Active { get; set; }
    }
}
