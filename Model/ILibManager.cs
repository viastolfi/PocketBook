using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ILibManager
    {
        List<Book> GetBooks();
        Book GetBook();
    }
}
