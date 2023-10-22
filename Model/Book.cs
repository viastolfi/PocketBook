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
        public string Id { get; set; }
        public string Title {get; set;}
        public Status Status { get; set; }

        public Book(string id, string title)
        {
            Id = id;
            Title = title;
            Status = Status.Unread;
        }
        
        public Book(){}
    }
}
