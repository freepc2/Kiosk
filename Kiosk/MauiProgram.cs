using Kiosk.Properties;
using Kiosk.Starter;
using Kiosk.ViewModels;
using Microsoft.Extensions.Logging;
using Kiosk.Views;
using Paul.Maui.Controls;

namespace Kiosk
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                //.UsePrism(prism =>
                //     prism.RegisterTypes(container => {
                //       //  container.Register<IViewable, MainPage>();
                //         container.RegisterForNavigation<MainPage, MainViewModel>();
                //     })
                //)
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
