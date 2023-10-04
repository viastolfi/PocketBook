using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Model;
using PocketBookVincentAstolfi.Stub;
using WrapperViewModel;
using PocketBookVincentAstolfi.ApplicativViewModel;

namespace PocketBookVincentAstolfi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services
			.AddSingleton<ILibManager, PocketBookStub>()
			.AddTransient<BooksViewModel>()
			.AddTransient<NavigationViewModel>()
			.AddTransient<MainPage>()
			.AddTransient<AllBooksPage>()
			.AddTransient<AllAuthorsPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
