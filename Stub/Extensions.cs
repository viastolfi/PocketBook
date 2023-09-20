using LibraryDTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public static class Extensions
    {
        public static Book ToPoco(this BookDTO bookDto)
        {
            var result = Mapper.BooksMapper.GetT(bookDto);
            if (result == null)
            {
                result = new Book
                {
                    Id = bookDto.Id,
                    Title = bookDto.Title,
                };
            }
            return result;
        }
        public static IEnumerable<Book> ToPocos(this IEnumerable<BookDTO> bookDtos)
            => bookDtos.Select(bookDto => bookDto.ToPoco());
    }

}