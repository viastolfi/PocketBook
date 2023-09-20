using Model;
using PocketBookVincentAstolfi.Stub;
using System.Diagnostics;

namespace PocketBookVincentAstolfi;

public partial class BookPreviewCV : ContentView
{

    public static readonly BindableProperty BooksProperty = BindableProperty.Create(nameof(Books), typeof(List<Book>), typeof(BookPreviewCV), new List<Book>());
    
    public List<Book> Books
    {
        get => (List<Book>)GetValue(BooksProperty);
        set => SetValue(BooksProperty, value);
    }
    public BookPreviewCV()
	{
        InitializeComponent();
	}
    async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
    {
        if (sender is View tappedView && tappedView.BindingContext is Book selectedBook)
        {
            await Navigation.PushAsync(new SpecificBookDescription(selectedBook));
        }
    }
}