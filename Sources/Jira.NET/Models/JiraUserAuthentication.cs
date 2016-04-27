using RestSharp.Serializers;

namespace Jira.NET.Models
{
    public class JiraUserAuthentication
    {
        public JiraUserAuthentication(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        [SerializeAs(Name = "username")]
        public string UserName { get; set; }
        [SerializeAs(Name = "password")]
        public string Password { get; set; }
    }
}
