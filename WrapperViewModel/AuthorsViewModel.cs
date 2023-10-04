using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;
using MyToolkit;

namespace WrapperViewModel
{
    public class AuthorsViewModel : INotifyPropertyChanged
    {
		private ObservableCollection<Author> _authors { get; set; } = new ObservableCollection<Author>();
		public ObservableCollection<Author> Authors
		{
			get => _authors;
			set
			{
				if (_authors != value) return;
				_authors = value;
				OnPropertyChanged(nameof(Authors));
			}
		}

		private ILibManager Manager;

		public AuthorsViewModel(ILibManager manager)
		{
			Manager = manager;

			AddAuthors();
		}

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		private void AddAuthors()
		{
			List<Author> temp = Manager.GetAuthors();
			Authors = new ObservableCollection<Author>();
			foreach(Author a in temp)
			{
				Authors.Add(a);
			}
		}
    }
}

