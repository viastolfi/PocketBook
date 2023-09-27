using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBookVincentAstolfi.Stub
{
    public class PocketBookStub : ILibManager
    {
        private List<Book> Books = new List<Book>();

        public PocketBookStub()
        {
            Book b = new Book("1", "Le Temps des Tempêtes");
            Books.Add(b);
        }

        public Book GetBook()
        {
            return Books.First();
        }

        public List<Book> GetBooks()
        {
            return Books;
        }
    }
}
