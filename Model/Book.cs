using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public string Name { get; set; }
        public Author Author {  get; set; }
        public bool Status { get; set; }
        public bool Favorit { get; set; }
        public int Note {  get; set; }
        public ImageSource Cover { get; set; }

        public Book(string name, Author author, bool status, bool favorit, int note, ImageSource cover)
        {
            this.Name = name;
            this.Author = author;
            this.Status = status;
            this.Favorit = favorit;
            this.Note = note;
            this.Cover = cover;
        }
    }
}
