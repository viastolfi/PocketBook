using System.Net;
using PocketBookVincentAstolfi.ApplicativViewModel;
using WrapperViewModel;

namespace PocketBookVincentAstolfi;

public partial class SpecificBookDescriptionPage : ContentPage
{
    private SpecificBookPageViewModel SpecificBookPageViewModel;

    public SpecificBookDescriptionPage(SpecificBookPageViewModel specificBookPageViewModel)
    {
        SpecificBookPageViewModel = specificBookPageViewModel;

        InitializeComponent();

        BindingContext = SpecificBookPageViewModel;
    }
}