using Kiosk.ViewModels;
using Kiosk.Views;
using Paul.Maui.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainPage, MainViewModel>();
        }
    }


}
