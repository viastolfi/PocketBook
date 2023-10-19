using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Author
    {
        public string Name { get; set; }
        public List<Book> WritedBooks { get; set; } = new List<Book>();

        public Author(string name, List<Book> books) 
        {
            Name = name;
            WritedBooks = books;
        }

        public Author(string name)
        {
            Name = name;
        }
    }
}
