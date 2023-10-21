using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using WrapperViewModel;
using PocketBookVincentAstolfi.ApplicativViewModel;
using Model;
using Stub;

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

			.AddSingleton<BookViewModel>()
			.AddTransient<NavigationViewModel>()
			.AddSingleton<AuthorsViewModel>()
			.AddSingleton<SpecificBookPageViewModel>()

			.AddTransient<MainPage>()
			.AddTransient<AllBooksPage>()
			.AddTransient<AllAuthorsPage>()
			.AddTransient<SpecificBookDescriptionPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
