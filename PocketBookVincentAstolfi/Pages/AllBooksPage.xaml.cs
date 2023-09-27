namespace PocketBookVincentAstolfi;

using Model;
using PocketBookVincentAstolfi.Stub;
using System.Collections.ObjectModel;
using WrapperViewModel;

public partial class AllBooksPage : ContentPage
{
	private BooksViewModel Manager;
	public AllBooksPage(BooksViewModel manager)
	{
		InitializeComponent();

		Manager = manager;

		BindingContext = manager;
	}

	async private void GoBackClick(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
    }
}