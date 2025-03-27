using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Controls
{
    internal interface IViewInitializable
    {
        void OnViewWired(IViewable view);
    }
}
