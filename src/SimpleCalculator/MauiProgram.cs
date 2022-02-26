namespace SimpleCalculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("DigitalDismay.otf", "DigitalDismay");
			});

		return builder.Build();
	}
}
