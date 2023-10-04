using Model;
using MyToolkit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace WrapperViewModel
{
    // All the code in this file is included in all platforms.
    public class BooksViewModel : ObervableObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => MyOnPropertyChanged(ref _name, value);
        }

        private string _id;
        public string Id
        {
            get => _id;
            set => MyOnPropertyChanged(ref _id, value);
        }

        private ILibManager LibManager;

        public BooksViewModel(ILibManager libManager)
        {
            this.LibManager = libManager;

            Book b = libManager.GetBook();
            Name = b.Title;
            Id = b.Id;
        }
    }
}