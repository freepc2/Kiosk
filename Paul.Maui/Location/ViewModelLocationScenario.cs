using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul.Maui.Location
{
    public abstract class ViewModelLocationScenario
    {
        internal ViewModelLocatorCollection Publish()
        {
            ViewModelLocatorCollection Items = new ViewModelLocatorCollection();
            Match(Items);
            return Items;
        }
        public ViewModelLocationScenario()
        {

        }
        protected abstract void Match(ViewModelLocatorCollection items);
    }
}
