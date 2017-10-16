using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GetAPIData
{
    class Utils
    {
        public static void getAllPosts(JArray posts)
        {
            try
            {
                for (int i = 0; i < posts.Count; i++)
                {
                    int id = int.Parse(posts[i]["id"].ToString());
                    DateTime date = DateTime.Parse(posts[i]["date"].ToString());
                    DateTime date_gmt = DateTime.Parse(posts[i]["date_gmt"].ToString());
                    string guid = posts[i]["guid"].ToString();
                    DateTime modified = DateTime.Parse(posts[i]["modified"].ToString());
                    DateTime modified_gmt = DateTime.Parse(posts[i]["modified_gmt"].ToString());
                    string slug = posts[i]["slug"].ToString();
                    string status = posts[i]["status"].ToString();
                    string type = posts[i]["type"].ToString();
                    string link = posts[i]["link"].ToString();
                    string title = posts[i]["title"]["rendered"].ToString();
                    int author = int.Parse(posts[i]["author"].ToString());
                    int featured_media = int.Parse(posts[i]["featured_media"].ToString());
                    string comment_status = posts[i]["comment_status"].ToString();
                    string ping_status = posts[i]["ping_status"].ToString();
                    bool sticky = (bool)posts[i]["sticky"];
                    string template = posts[i]["template"].ToString();
                    string format = posts[i]["format"].ToString();
                    // List<object> meta
                    // List<int> categories
                    // List<int> tags
                    Post p = new Post(id, date, date_gmt, guid, modified, modified_gmt, slug, status, type, link, title, author, featured_media, comment_status, ping_status, sticky, template, format);
                    Program.allPosts.Add(p);
                }
            }
            catch (CustomErrors e)
            {
                //throw;
                throw new CustomErrors("Ocoreu um erro na definição de posts. Message: " + e.Message + ". InnerException: " + e.InnerException);
            }
        }
    }
}
