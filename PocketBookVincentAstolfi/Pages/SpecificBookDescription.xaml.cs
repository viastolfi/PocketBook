using System.Net;
using PocketBookVincentAstolfi.ApplicativViewModel;
using WrapperViewModel;

namespace PocketBookVincentAstolfi;

public partial class SpecificBookDescription : ContentPage
{
    private SpecificBookPageViewModel SpecificBookPageViewModel;

    public SpecificBookDescription(SpecificBookPageViewModel specificBookPageViewModel)
    {
        SpecificBookPageViewModel = specificBookPageViewModel;

        InitializeComponent();

        BindingContext = SpecificBookPageViewModel;
    }

    async private void GoBackClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}