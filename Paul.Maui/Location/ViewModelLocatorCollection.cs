using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Location
{
    public class ViewModelLocatorCollection : List<ViewModelLocatorItem>
    {
        public void Register<T1, T2>()
        {
            ViewModelLocationProvider.Register<T1, T2>();
            this.Add(new ViewModelLocatorItem(typeof(T1), typeof(T2)));
        }
    }
}
