using Model;

namespace PocketBookVincentAstolfi;

public partial class SpecificBookDescription : ContentPage
{
    public SpecificBookDescription(Book selectedBook)
    {
        InitializeComponent();
        BindingContext = selectedBook; 
    }

    async private void GoBackClick(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}