using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using java.awt.print;

namespace serialization
{
    class BookSerialization
    {
        public static void BooksXML(List<Book> books)
        {
            
            XmlSerializer xmls_books = new XmlSerializer(typeof(List<Book>));
            TextWriter tw_books = new StreamWriter("Books.xml");
            xmls_books.Serialize(tw_books, books);
        }

        public static void BooksJson(List<Book> books)
        {
            JsonSerializer jsons_books = new JsonSerializer();
            using (StreamWriter jsonsw_books = new StreamWriter("Books.json"))
            using (JsonWriter jw_books = new JsonTextWriter(jsonsw_books))
            {
                jsons_books.Serialize(jw_books, books);
            }
        }
    }
}