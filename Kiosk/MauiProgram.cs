using Kiosk.Properties;
using Kiosk.ViewModels;
using Microsoft.Extensions.Logging;

namespace Kiosk
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                //.UseMauiApp<App>()
                ////.UsePrism(prism => 
                ////    prism.ConfigureModuleCatalog(moduleCatalog => 
                ////    {
                ////        moduleCatalog.Add<ViewModules>();
                ////    })
                ////    .RegisterTypes(containerRegistry => 
                ////    {
                ////        containerRegistry.RegisterForNavigation<MainPage>();

                ////    })
                ////    .OnAppStart(navigationService => navigationService.CreateBuilder()
                ////    .AddSegment<MainViewModel>()
                ////    .NavigateAsync(HandleNavigationError))
                ////)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
