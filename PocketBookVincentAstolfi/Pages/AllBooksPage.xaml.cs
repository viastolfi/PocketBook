namespace PocketBookVincentAstolfi;

using Model;
using PocketBookVincentAstolfi.ApplicativViewModel;
using PocketBookVincentAstolfi.Stub;
using System.Collections.ObjectModel;
using WrapperViewModel;

public partial class AllBooksPage : ContentPage
{
	public AuthorsViewModel Manager { get; private set; }
	public NavigationViewModel NavigationManager { get; private set; }

	public AllBooksPage(AuthorsViewModel manager, NavigationViewModel navigationManager)
	{
		InitializeComponent();

		Manager = manager;
		NavigationManager = navigationManager;

		BindingContext = this;
	}

	async private void GoBackClick(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
    }
}