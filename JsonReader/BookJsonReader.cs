using System.Globalization;
using LibraryDTO;
using Newtonsoft.Json.Linq;

namespace JsonReader;

public static class BookJsonReader
{
    public static BookDTO ReadBook(string json)
    {
        JObject o = JObject.Parse(json);

        BookDTO book = new BookDTO
        {
            Id = (string)o["key"],
            Title = (string)o["title"],
        };
        return book;
    }
}
