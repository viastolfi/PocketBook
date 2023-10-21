using Model;
using PocketBookVincentAstolfi.ApplicativViewModel;
using Stub;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace PocketBookVincentAstolfi;

public partial class BookPreviewContentView : ContentView
{
    public static readonly BindableProperty BooksProperty =
        BindableProperty.Create(nameof(Books), typeof(ObservableCollection<Book>), typeof(BookPreviewContentView), new ObservableCollection<Book>());

    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(BookPreviewContentView));
    
    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
    
    public ObservableCollection<Book> Books
    {
        get => (ObservableCollection<Book>)GetValue(BooksProperty);
        set => SetValue(BooksProperty, value);
    }

    public BookPreviewContentView()
	{
        InitializeComponent();
	}

}