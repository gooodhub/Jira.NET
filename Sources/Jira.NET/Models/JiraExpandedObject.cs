using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraExpandedObject<T>
    {
        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        [DeserializeAs(Name = "items")]
        public List<T> Items { get; set; }

        [DeserializeAs(Name = "max-results")]
        public int MaxResults { get; set; }

        [DeserializeAs(Name = "start-index")]
        public int StartIndex { get; set; }

        [DeserializeAs(Name = "end-index")]
        public int EndIndex { get; set; }
    }
}
