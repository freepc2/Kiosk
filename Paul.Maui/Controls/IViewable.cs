using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Controls
{
    public interface IViewable
    {
        VisualElement View { get; }
        INotifyPropertyChanged ViewModel { get; }
    }
}
