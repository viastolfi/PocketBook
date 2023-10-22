using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;
using MyToolkit;

namespace WrapperViewModel
{
    public class AuthorViewModel : ObervableObject
    {
	    private Author _author;
	    
	    public string Name
		{
			get => _author.Name;
			set => MyOnPropertyChanged(_author.Name, value, v => _author.Name = v);
		}

        public ReadOnlyObservableCollection<Book> Books { get; set; }
        private readonly ObservableCollection<Book> _books;

        public AuthorViewModel(Author author)
        {
	        _author = author;
	        _books = new ObservableCollection<Book>(_author.WritedBooks);
	        Books = new ReadOnlyObservableCollection<Book>(_books);
	        OnPropertyChanged(nameof(Books));
        }
	}
}

