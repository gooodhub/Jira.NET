using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraUserLogin
    {
        [DeserializeAs(Name = "session")]
        public JiraUserSession Session { get; set; }
        [DeserializeAs(Name = "loginInfo")]
        public JiraUserLoginInfo LoginInfo { get; set; }
    }
}
