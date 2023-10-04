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
        private List<Author> Authors = new List<Author>();

        public PocketBookStub()
        {
            CreateBooks();
            CreateAuthors();
        }

        public Book GetBook()
        {
            return Books.First();
        }

        public List<Book> GetBooks()
        {
            return Books;
        }

        private void CreateBooks()
        {
            Book b = new Book("1", "Le Temps des Tempêtes");
            Book b2 = new Book("2", "Promenades"); 
            Books.Add(b);
            Books.Add(b2);
        }

        private void CreateAuthors()
        {
            Author a = new Author("Nicolas Sarcozy");
            a.WritedBooks.AddRange(Books);
            Authors.Add(a);
        }

        public List<Author> GetAuthors()
        {
            return Authors;
        }
    }
}
