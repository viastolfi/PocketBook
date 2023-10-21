namespace PocketBookVincentAstolfi;

using PocketBookVincentAstolfi.ApplicativViewModel;
using System.Collections.ObjectModel;
using WrapperViewModel;

public partial class AllBooksPage : ContentPage
{
	public AuthorsViewModel Manager { get; private set; }
	public SpecificBookPageViewModel NavigationManager { get; private set; }

	public AllBooksPage(AuthorsViewModel manager, SpecificBookPageViewModel navigationManager)
	{
		Manager = manager;
		NavigationManager = navigationManager;

		InitializeComponent();

		BindingContext = this;
	}

    protected override void OnAppearing()
    {
		Manager.LoadData();
        base.OnAppearing();
    }
}