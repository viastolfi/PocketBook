using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBookVincentAstolfi.Stub
{
    public class PocketBookStub
    {
        public List<Book> books = new List<Book>();
        public List<Author> authors = new List<Author>();

        public PocketBookStub() 
        {
           Author alain = new Author("Alain Damassio");
           Author test = new Author("test");
           Book b = new Book("La horde du contrevenant", alain, false, true, 0, "book_cover_1", "97346389594", 700, "français", "ceci est une super description qui a pour but de montrer plusieurs choses a mon professeurs");
           Book b2 = new Book("Le pouvoir du dehors", alain, false, true, 0, "le_pouvoir_du_dehors_cover", "97346389594", 700, "français", "ceci est une super description qui a pour but de montrer plusieurs choses a mon professeurs");

            alain.WritedBooks.Add(b);
            alain.WritedBooks.Add(b2);
            authors.Add(alain);
            authors.Add(test);
        }
    }
}
