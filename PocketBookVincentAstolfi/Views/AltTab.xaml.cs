namespace PocketBookVincentAstolfi;

using System.Windows.Input;
using PocketBookVincentAstolfi.ApplicativViewModel;

public partial class AltTab : ContentView
{
	public static readonly BindableProperty SectionTitleProperty = BindableProperty.Create(nameof(SectionTitle), typeof(string), typeof(AltTab), string.Empty);
	public static readonly BindableProperty OccurrencieNumberProperty = BindableProperty.Create(nameof(OccurrencieNumber), typeof(string), typeof(AltTab), string.Empty);
    public static readonly BindableProperty SectionIconProperty = BindableProperty.Create(nameof(SectionIcon), typeof(ImageSource), typeof(AltTab));
	public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(AltTab));
	public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(string), typeof(AltTab));

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

	public ICommand Command
	{
		get => (ICommand)GetValue(CommandProperty);
		set => SetValue(CommandProperty, value);
	}

	public string CommandParameter
	{
		get => (string)GetValue(CommandParameterProperty);
		set => SetValue(CommandParameterProperty, value);
	}

    public AltTab()
	{
		InitializeComponent();
	}
}