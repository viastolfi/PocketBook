using Model;
using PocketBookVincentAstolfi.ApplicativViewModel;
using PocketBookVincentAstolfi.Stub;

namespace PocketBookVincentAstolfi;

public partial class AllAuthorsPage : ContentPage
{
	public NavigationViewModel NavigationManager { get; private set; }
	public AllAuthorsPage(NavigationViewModel navigationManager)
	{
		NavigationManager = navigationManager;
		InitializeComponent();

		BindingContext = this;
    }
}