using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Location
{
    public class ViewModelLocatorItem
    {
        public ViewModelLocatorItem(Type viewType, Type dataContextType)
        {
            ViewType = viewType;
            DataContextType = dataContextType;
        }

        public Type ViewType { get; set; }
        public Type DataContextType { get; set; }
    }
}
