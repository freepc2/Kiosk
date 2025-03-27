using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Controls
{
    public interface IViewLoadable
    {
        void OnLoaded(IViewable view);
    }
}
