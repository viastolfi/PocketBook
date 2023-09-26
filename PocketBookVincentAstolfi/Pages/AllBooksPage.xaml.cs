namespace PocketBookVincentAstolfi;

using Model;
using PocketBookVincentAstolfi.Stub;
using System.Collections.ObjectModel;
using WrapperViewModel;

public partial class AllBooksPage : ContentPage
{
	public AllBooksPage(ILibManager manager)
	{
		InitializeComponent();

		MyCollectionView.ItemsSource = (System.Collections.IEnumerable)manager.GetBooks();
	}

	//private List<Author> GetAuthors()
	//{
	//	PocketBookStub pocketBookStub = new PocketBookStub();
	//	return pocketBookStub.authors;
	//} 

	async private void GoBackClick(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
    }
}