using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace WrapperViewModel
{
    // All the code in this file is included in all platforms.
    public class BooksViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if(!string.Equals(_name, value))
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if(!string.Equals(_id, value))
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
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