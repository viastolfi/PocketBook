namespace PocketBookVincentAstolfi;

using PocketBookVincentAstolfi.ApplicativViewModel;
using System.Collections.ObjectModel;
using WrapperViewModel;

public partial class AllBooksPage : ContentPage
{
	public SpecificBookPageViewModel SpecificBookPageViewModel { get; private set; }
	public AuthorsViewModel AuthorsViewModel { get; private set; }
	
	public AllBooksPage(AuthorsViewModel authorsViewModel, SpecificBookPageViewModel specificBookPageViewModel)
	{
		 AuthorsViewModel = authorsViewModel;
		 SpecificBookPageViewModel = specificBookPageViewModel;

		InitializeComponent();

		BindingContext = this;
	}
}