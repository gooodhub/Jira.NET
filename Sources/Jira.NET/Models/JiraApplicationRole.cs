using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraApplicationRole:JiraObject
    {
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "groups")]
        public List<string> Groups { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "defaultGroups")]
        public List<string> DefaultGroups { get; set; }

        [DeserializeAs(Name = "selectedByDefault")]
        public bool SelectedByDefault { get; set; }

        [DeserializeAs(Name = "defined")]
        public bool Defined { get; set; }

        [DeserializeAs(Name = "numberOfSeats")]
        public int NumberOfSeats { get; set; }

        [DeserializeAs(Name = "remainingSeats")]
        public int RemainingSeats { get; set; }

        [DeserializeAs(Name = "userCount")]
        public int UserCount { get; set; }

        [DeserializeAs(Name = "userCountDescription")]
        public string UserCountDescription { get; set; }

        [DeserializeAs(Name = "hasUnlimitedSeats")]
        public bool HasUnlimitedSeats { get; set; }

        [DeserializeAs(Name = "platform")]
        public bool Platform { get; set; }
    }
}
