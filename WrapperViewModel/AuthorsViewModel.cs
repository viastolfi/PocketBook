using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;
using MyToolkit;

namespace WrapperViewModel
{
    public class AuthorsViewModel : INotifyPropertyChanged
    {
		private List<AuthorViewModel> _authors = new List<AuthorViewModel>();
		public ObservableCollection<AuthorViewModel> Authors
		{
			get => new ObservableCollection<AuthorViewModel>(_authors);
			set
			{
				if (new ObservableCollection<AuthorViewModel>(_authors) != value) return;
				_authors = new List<AuthorViewModel>(value);
				OnPropertyChanged(nameof(Authors));
			}
		}

		private ILibManager Manager;

        public void LoadData()
		{
            foreach (Author a in Manager.GetAuthors())
            {
                _authors.Add(new AuthorViewModel(a));
            }
        }

        public AuthorsViewModel(ILibManager manager)
		{
			Manager = manager;
			LoadData();
		}

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

