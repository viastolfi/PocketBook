using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;

namespace WrapperViewModel
{
    public class AuthorViewModel : INotifyPropertyChanged
	{
		private Author _author;

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public string Name
		{
			get => _author.Name;
			set
			{
				if(_author.Name != value)
				{
					_author.Name = value;
					OnPropertyChanged(nameof(Name));
				}
			}
		}

		public ObservableCollection<Book> Books
		{
			get => new ObservableCollection<Book>(_author.WritedBooks);
			set
			{
				if(new ObservableCollection<Book>(_author.WritedBooks) != value)
				{
					_author.WritedBooks = new List<Book>(value);
					OnPropertyChanged(nameof(Books));
				}
			}
		}

		public AuthorViewModel(Author author)
		{
			_author = author;
		}
	}
}

