using Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace WrapperViewModel
{
    // All the code in this file is included in all platforms.
    public class BooksViewModel
    {
        private List<Book> Books;
        private ILibManager LibManager;

        public BooksViewModel(ILibManager libManager)
        {
            this.LibManager = libManager;

        }

        public async Task<List<Book>> GetBooks()
        {
            return await LibManager.GetBooks();
        }
    }
}