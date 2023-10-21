using System;
using System.Windows.Input;
using WrapperViewModel;

namespace PocketBookVincentAstolfi.ApplicativViewModel
{
	public class SpecificBookPageViewModel : NavigationViewModel
	{
        public ICommand NavigateToPageWithBookCommand { get; private set; }
        public BookViewModel BookViewModel { get; private set; }

		public SpecificBookPageViewModel(BookViewModel bookViewModel)
			:base()
		{
			BookViewModel = bookViewModel;

            NavigateToPageWithBookCommand = new Command<string>(
              async (string id) =>
              {
                  BookViewModel.GetBookById(id);
                  var route = "SpecificBookDescriptionPage";
                  await Shell.Current.GoToAsync(route);
              }
            );
        }
	}
}