using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraType
    {
        public class Type
        {

            [DeserializeAs(Name = "id")]
            public string Id { get; set; }

            [DeserializeAs(Name = "name")]
            public string Name { get; set; }

            [DeserializeAs(Name = "inward")]
            public string Inward { get; set; }

            [DeserializeAs(Name = "outward")]
            public string Outward { get; set; }
        }
    }
}
