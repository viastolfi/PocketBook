using PocketBookVincentAstolfi.ApplicativViewModel;

namespace PocketBookVincentAstolfi;

public partial class MainPage : ContentPage
{
	public NavigationViewModel Manager { get; private set; }
	public MainPage(NavigationViewModel vm)
	{
		InitializeComponent();
		Manager = vm;
		BindingContext = Manager;
	}
}

