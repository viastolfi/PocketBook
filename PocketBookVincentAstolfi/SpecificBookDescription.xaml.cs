using Model;

namespace PocketBookVincentAstolfi;

public partial class SpecificBookDescription : ContentPage
{
    public SpecificBookDescription(Book selectedBook)
    {
        InitializeComponent();
        BindingContext = selectedBook; 
    }
}