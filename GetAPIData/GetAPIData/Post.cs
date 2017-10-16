using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAPIData
{
    public class Post
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public DateTime date_gmt { get; set; }
        public string guid { get; set; }
        public DateTime modified { get; set; }
        public DateTime modified_gmt { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public int author { get; set; }
        public int featured_media { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public bool sticky { get; set; }
        public string template { get; set; }
        public string format { get; set; }
        public List<object> meta { get; set; }
        public List<int> categories { get; set; }
        public List<int> tags { get; set; }

        public Post(int id, DateTime date, DateTime date_gmt, string guid, DateTime modified, DateTime modified_gmt, string slug, string status, string type, string link, string title, int author, int featured_media, string comment_status, string ping_status, bool sticky, string template, string format)
        {
            this.id = id;
            this.date = date;
            this.date_gmt = date_gmt;
            this.guid = guid;
            this.modified = modified_gmt;
            this.slug = slug;
            this.status = status;
            this.type = type;
            this.link = link;
            this.title = title;
            this.author = author;
            this.featured_media = featured_media;
            this.comment_status = comment_status;
            this.ping_status = ping_status;
            this.sticky = sticky;
            this.template = template;
            this.format = format;
        }
        
        public override string ToString()
        {
            // return base.ToString();
            return "Assunto: " + HttpUtility.HtmlDecode(title)
                + "\n [+] URL: " + link
                + "\n [+] Data: " + date.ToString("dd/MM/yyyy");
        }
    }
}
