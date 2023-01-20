using Microsoft.Extensions.Logging;
using MVVMTest.Containers;
using MVVMTest.View;
using MVVMTest.ViewModel;

namespace MVVMTest;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<CarView>(); //just create a car for
        builder.Services.AddSingleton<CarViewModel>();
		builder.Services.AddSingleton<SelectedCars>();
        return builder.Build();
	}
}
