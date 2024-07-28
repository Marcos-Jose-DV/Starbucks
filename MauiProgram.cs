using AppStarbucks.Pages;
using AppStarbucks.Services;
using AppStarbucks.ViewModels;
using Microsoft.Extensions.Logging;

namespace AppStarbucks;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<LoginViewModel>();
		builder.Services.AddSingleton<IAuthService, AuthService>();

		//Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
