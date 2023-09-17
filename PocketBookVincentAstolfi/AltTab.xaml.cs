namespace PocketBookVincentAstolfi;

public partial class AltTab : ContentView
{
	public static readonly BindableProperty SectionTitleProperty = BindableProperty.Create(nameof(SectionTitle), typeof(string), typeof(AltTab), string.Empty);
	public static readonly BindableProperty OccurrencieNumberProperty = BindableProperty.Create(nameof(OccurrencieNumber), typeof(string), typeof(AltTab), string.Empty);
    public static readonly BindableProperty SectionIconProperty = BindableProperty.Create(nameof(SectionIcon), typeof(ImageSource), typeof(AltTab));
    public ImageSource SectionIcon
	{
		get => GetValue(SectionIconProperty) as ImageSource;
		set => SetValue(SectionIconProperty, value);
	}
	public string OccurrencieNumber
	{
		get => (string)GetValue(OccurrencieNumberProperty);
		set => SetValue(OccurrencieNumberProperty, value);
	}
	public string SectionTitle
	{
		get => (string)GetValue(SectionTitleProperty); 
		set => SetValue(SectionTitleProperty, value);
	}
    public Type TargetPageType { get; set; }

    public AltTab()
	{
		InitializeComponent();
	}

	async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
	{
        if (TargetPageType != null)
        {
            var page = (Page)Activator.CreateInstance(TargetPageType);
            await Navigation.PushAsync(page);
        }
    }
}