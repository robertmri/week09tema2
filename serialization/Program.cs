using java.awt.print;
using SummaryBookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Fill(BooksCrud.GetTop10PBooks());
            BookSerialization.BooksJson(books);
            BookSerialization.BooksXML(books);
        }
    }
}
