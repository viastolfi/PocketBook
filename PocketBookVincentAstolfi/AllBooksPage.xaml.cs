namespace PocketBookVincentAstolfi;

using Model;
using PocketBookVincentAstolfi.Stub;
using System.Collections.ObjectModel;

public partial class AllBooksPage : ContentPage
{
	public AllBooksPage()
	{
		InitializeComponent();

		MyCollectionView.ItemsSource = GetAuthors();
	}

	private List<Author> GetAuthors()
	{
		PocketBookStub pocketBookStub = new PocketBookStub();
		return pocketBookStub.authors;
	}

	async private void GoBackClick(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
    }
}