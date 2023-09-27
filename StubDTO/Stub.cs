using JsonReader;
using LibraryDTO;
using Microsoft.Maui.Controls.Compatibility;

namespace StubDTO
{
    // All the code in this file is included in all platforms.
    public class Stub
    {
        public List<BookDTO> Books { get; set; } = new List<BookDTO>();
        public static string BasePath { get; set; } = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        string test = "{\n  \"title\": \"L'\\u00c9veil du L\\u00e9viathan\",\n  \"key\": \"/books/OL25910297M\"\n}";

        public Stub() 
        {
            var book = BookJsonReader.ReadBook(test);
            Books.Add(book);
        }

        public Task<List<BookDTO>> GetBooks()
        {
            return Task.FromResult(Books);
        }
    }
}