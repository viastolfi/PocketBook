 using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;
 using MyToolkit;

 namespace WrapperViewModel
{
    public class AuthorsViewModel : ObervableObject
    {
	    private readonly ObservableCollection<AuthorViewModel> _authors;
	    public ReadOnlyObservableCollection<AuthorViewModel> Authors { get; set; }
	    
		private ILibManager Manager;

        public List<AuthorViewModel> LoadData()
        {
	        List<AuthorViewModel> authors = new List<AuthorViewModel>();
            foreach (Author a in Manager.GetAuthors())
            {
                authors.Add(new AuthorViewModel(a));
            }

            return authors;
		}

        public AuthorsViewModel(ILibManager manager)
		{
			Manager = manager;
			_authors = new ObservableCollection<AuthorViewModel>(LoadData());
			Authors = new ReadOnlyObservableCollection<AuthorViewModel>(_authors);
			OnPropertyChanged(nameof(Authors));
		}
    }
}

