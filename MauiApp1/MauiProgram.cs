using MauiApp1.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
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

            //Added for enabling the option of application running only if there is internet
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            //Added for Main Page and Singleton because only one Main Page
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            //Added for Detail Page and Transient because may extend Detail Page to various Pages
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
