using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraWatchers
    {
            [DeserializeAs(Name = "self")]
            public string Self { get; set; }

            [DeserializeAs(Name = "iswatching")]
            public bool IsWatching { get; set; }

            [DeserializeAs(Name = "watchcount")]
            public int WatchCount { get; set; }

            [DeserializeAs(Name = "watchers")]
            public IList<JiraWatcher> Watchers { get; set; }
    }
}
