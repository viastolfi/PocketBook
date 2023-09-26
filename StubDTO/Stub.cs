using JsonReader;
using LibraryDTO;
using Microsoft.Maui.Controls.Compatibility;

namespace StubDTO
{
    // All the code in this file is included in all platforms.
    public class Stub
    {
        public List<BookDTO> Books { get; set; } = new List<BookDTO>();
        public static string BasePath { get; set; } = "./";

        public Stub() 
        {
            foreach (var fileBook in new DirectoryInfo("books").GetFiles())
            {
                using (StreamReader reader = File.OpenText(fileBook.FullName))
                {
                    var book = BookJsonReader.ReadBook(reader.ReadToEnd());
                    Books.Add(book);
                }
            }
        }

        public Task<List<BookDTO>> GetBooks()
        {
            return Task.FromResult(Books);
        }
    }
}