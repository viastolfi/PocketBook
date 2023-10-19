using System;
using System.Windows.Input;

namespace PocketBookVincentAstolfi.ApplicativViewModel
{
	public class NavigationViewModel 
	{
		public ICommand NavigateToPage { get; private set; }
		public ICommand NavigateBackCommand { get; private set; }

        public NavigationViewModel()
		{
			NavigateToPage = new Command<string>(
				async (string path) => await Shell.Current.GoToAsync(path)
			);

			NavigateBackCommand = new Command(
				async () => await Shell.Current.GoToAsync("..")
			);

      
        }
	}
}

