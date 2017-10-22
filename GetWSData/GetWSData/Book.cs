using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GetWSData
{
    [XmlRoot("book")] // definindo o elemento root para leitura dos nodes abaixo
    [XmlType("book")] // como o retorno do XML é 'book' (ao invés de 'Book', que é o mesmo nome da classe) 
                      // e o serialize é case-sensitive, foi necessário definir o XMLType como 'book'
    public class Book
    {
        
        public string author { get; set; }
        
        public string title { get; set; }
        
        public string genre { get; set; }
        
        public double price { get; set; }

        public DateTime pub_date { get; set; }
        
        public string review { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return "Autor: " + author
                   + "\n Titulo: " + title
                   + "\n Genero: " + genre
                   + "\n Preço: " + price.ToString("F2", CultureInfo.InvariantCulture)
                   + "\n Data Publicação: " + pub_date.ToString("dd/MM/yyyy")
                   + "\n Review: " + review + "\n\n";

        }
    }   
}
