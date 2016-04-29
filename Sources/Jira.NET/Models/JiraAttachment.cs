using System;
using RestSharp.Deserializers;

namespace Jira.NET.Models
{
    public class JiraAttachment
    {
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

        [DeserializeAs(Name = "filename")]
        public string Filename { get; set; }

        [DeserializeAs(Name = "author")]
        public JiraAuthor Author { get; set; }

        [DeserializeAs(Name = "created")]
        public DateTime Created { get; set; }

        [DeserializeAs(Name = "size")]
        public int Size { get; set; }

        [DeserializeAs(Name = "mimeType")]
        public string MimeType { get; set; }

        [DeserializeAs(Name = "content")]
        public string Content { get; set; }

        [DeserializeAs(Name = "thumbnail")]
        public string Thumbnail { get; set; }
        }
}
