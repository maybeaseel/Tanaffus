using Microsoft.Extensions.Logging;
using Tanaffus.Views;

namespace Tanaffus;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("IBMPlexSansArabic-Regular.ttf", "PlexRegular");
                fonts.AddFont("IBMPlexSansArabic-Medium.ttf", "PlexMedium");
                fonts.AddFont("IBMPlexSansArabic-SemiBold.ttf", "PlexSemiBold");
                fonts.AddFont("IBMPlexSansArabic-Bold.ttf", "PlexBold");
            });

        // Pages are registered so that Shell can create them through dependency injection.
        builder.Services.AddTransient<SignInPage>();
        builder.Services.AddTransient<CreateAccountPage>();
        builder.Services.AddTransient<TodayPage>();
        builder.Services.AddTransient<LogPage>();
        builder.Services.AddTransient<TrendsPage>();
        builder.Services.AddTransient<ProfilePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
