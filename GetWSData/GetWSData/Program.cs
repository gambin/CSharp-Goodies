using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using GetWSData.SampleWS;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;

namespace GetWSData
{
    class Program
    {
        static void Main(string[] args)
        {

            // Iniciando objeto WS
            SampleWebService webService = new SampleWebService();
            XmlDocument xmlDoc = new XmlDocument();

            // Carregando 'xmldoc' com retorno da chamada em WS XML
            // Como as tags do XML de retorno utilizam prefixo, mas não possuem namespace em todos os nodes,
            // foi necessário fazer um replace do atual prefixo utilizado
            xmlDoc.LoadXml(webService.GetXmlData().OuterXml.Replace("x:", ""));
            
            // Salvando XML local para analise de estrutura. Apenas para testes e validação de output
            // xmldoc.Save("C:\\temp\\xmldoc.xml");

            //Iniciando processo de deserialização em um objeto do tipo 'book' no conjunto bList
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("books"));
            StringReader stringReader = new StringReader(xmlDoc.OuterXml);
            List<Book> bList = (List<Book>)serializer.Deserialize(stringReader);

            // Impressao de retorno em tela
            for (int i = 0; i < bList.Count; i++)
            {
                Console.WriteLine(bList[i]);
            }
            
            Console.ReadLine();
        }
    }
}
