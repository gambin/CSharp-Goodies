using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetAPIData
{
    class Program
    {
        public static List<Post> allPosts = new List<Post>();
        static void Main(string[] args)
        {
            try
            {
                string url = "";
                int pNum = 0;
                do
                {
                    Console.WriteLine("Entre como o endereço do site root do blog wordpress (ex.: http://tarcisiogambin.net/blog)");
                    url = Console.ReadLine();
                } while (url == null || string.IsNullOrEmpty(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute));

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Entre com o número de posts (1 ~ 100)");
                    pNum = int.Parse(Console.ReadLine());
                } while (pNum == 0 || pNum > 100);

                WebRequest wRequest;
                Console.WriteLine();
                Console.WriteLine("Aguarde...");
                wRequest = WebRequest.CreateHttp(url + "/wp-json/wp/v2/posts?per_page=" + pNum);
                wRequest.Method = "GET";

                // requisicaoWeb.UserAgent = "RequisicaoWebDemo";
                using (var response = wRequest.GetResponse())
                {
                    var streamDados = response.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    JArray results = JArray.Parse(objResponse.ToString());
                    Utils.getAllPosts(results);
                    streamDados.Close();
                    response.Close();

                    Console.WriteLine();
                    Console.WriteLine("ULTIMOS " + pNum + " POSTS: ");
                    Console.WriteLine();
                    for (int i = 0; i < allPosts.Count; i++)
                    {
                        Console.WriteLine(allPosts[i]);
                        Console.WriteLine();
                    }
                }
            }
            catch (CustomErrors e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
            catch (WebException e)
            {
                //using (var stream = ex.Response.GetResponseStream())
                //using (var reader = new StreamReader(stream))
                //{
                //    Console.WriteLine(reader.ReadToEnd());
                //}
                Console.WriteLine("Ocorreu um erro na requisição. A URL não é de um blog wordpress válido.");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ocorreu um erro na formatação de dados.");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadLine();
        }
    }
}
