using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraTimeTracking
    {

        [DeserializeAs(Name = "originalEstimate")]
        public string OriginalEstimate { get; set; }

        [DeserializeAs(Name = "remainingEstimate")]
        public string RemainingEstimate { get; set; }

        [DeserializeAs(Name = "timeSpent")]
        public string TimeSpent { get; set; }

        [DeserializeAs(Name = "originalEstimateSeconds")]
        public int OriginalEstimateSeconds { get; set; }

        [DeserializeAs(Name = "remainingEstimateSeconds")]
        public int RemainingEstimateSeconds { get; set; }

        [DeserializeAs(Name = "timeSpentSeconds")]
        public int TimeSpentSeconds { get; set; }
    }
}
