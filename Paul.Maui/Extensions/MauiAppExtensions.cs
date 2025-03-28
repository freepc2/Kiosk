using Paul.Maui.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Extensions
{
    public static class MauiAppExtensions
    {
        private static readonly List<IModule> _modules = new List<IModule>();
        private static object _theme;

        public static MauiAppBuilder UsePrismApp<T>(this MauiAppBuilder builder) where T : Application, new()
        {
            builder.UseMauiApp<T>();
            return builder;
        }
    
    }
}
