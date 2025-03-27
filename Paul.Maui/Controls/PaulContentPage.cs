using Paul.Maui.Composition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Controls
{
    public abstract class PaulContentPage : ContentPage, IViewable
    {
        private readonly AutoWireManager autoWireManager;
        public VisualElement View => autoWireManager.GetView();

        public INotifyPropertyChanged ViewModel => autoWireManager.GetDataContext();
        public PaulContentPage()
        {
            autoWireManager = new AutoWireManager();
            autoWireManager.InitializeAutoWire(this);
        }
    }
}
