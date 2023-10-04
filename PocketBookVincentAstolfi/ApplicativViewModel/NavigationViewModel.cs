using System;
using System.Windows.Input;

namespace PocketBookVincentAstolfi.ApplicativViewModel
{
	public class NavigationViewModel 
	{
		public ICommand NavigateToAllBooksCommand { get; private set; }

		public NavigationViewModel()
		{
			NavigateToAllBooksCommand = new Command<string>(
				async (string path) => await Shell.Current.GoToAsync(path)
			);
		}
	}
}

