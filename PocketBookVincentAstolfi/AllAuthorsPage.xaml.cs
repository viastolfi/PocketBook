using Model;
using PocketBookVincentAstolfi.Stub;

namespace PocketBookVincentAstolfi;

public partial class AllAuthorsPage : ContentPage
{
	public AllAuthorsPage()
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