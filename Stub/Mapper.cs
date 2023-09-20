using LibraryDTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Stub
{
    public static class Mapper
    {
        internal static Mapper<Book, BookDTO> BooksMapper { get; } = new Mapper<Book, BookDTO>();
    }
}
