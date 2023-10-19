namespace PocketBookVincentAstolfi;

using Model;
using PocketBookVincentAstolfi.ApplicativViewModel;
using Stub;
using WrapperViewModel;


public partial class AllAuthorsPage : ContentPage
{
	public NavigationViewModel NavigationManager { get; private set; }
	public AuthorsViewModel Manager { get; private set; }

	public AllAuthorsPage(NavigationViewModel navigationManager, AuthorsViewModel manager)
	{
		NavigationManager = navigationManager;
		Manager = manager;

		InitializeComponent();

		BindingContext = this;
    }
}