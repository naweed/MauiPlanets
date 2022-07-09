namespace MauiPlanets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Medium.ttf", "RegularFont");
                fonts.AddFont("Montserrat-SemiBold.ttf", "MediumFont");
                fonts.AddFont("Montserrat-Bold.ttf", "BoldFont");
			})
            .ConfigureLifecycleEvents(events =>
            {
#if ANDROID
                events.AddAndroid(android => android
                    .OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

                static void MakeStatusBarTranslucent(Android.App.Activity activity)
                {
                    activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);

                    activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);

                    activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
                }
#endif
            });

		return builder.Build();
	}
}

