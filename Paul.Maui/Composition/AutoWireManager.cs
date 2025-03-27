using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paul.Maui.Controls;
using Prism.Mvvm;

namespace Paul.Maui.Composition
{
    public class AutoWireManager
    {
        private VisualElement _view;

        public void InitializeAutoWire(VisualElement view)
        {
            _view = view;
            ViewModelLocationProvider.AutoWireViewModelChanged(view, AutoWireViewModelChanged);
        }

        public virtual void AutoWireViewModelChanged(object view, object dataContext)
        {
            _view.BindingContext = dataContext;
            if (dataContext is IViewInitializable viewInitializable)
            {
                viewInitializable.OnViewWired(view as IViewable);
            }

            if (dataContext is IViewLoadable && view is VisualElement frameworkElement)
            {
                frameworkElement.Loaded += Content_Loaded;
            }
        }

        private void Content_Loaded(object sender, EventArgs e)
        {
            if (sender is VisualElement frameworkElement && frameworkElement.BindingContext is IViewLoadable viewLoadable)
            {
                frameworkElement.Loaded -= Content_Loaded;
                viewLoadable.OnLoaded(frameworkElement as IViewable);
            }
        }

        public VisualElement GetView()
        {
            return _view;
        }

        public INotifyPropertyChanged GetDataContext()
        {
            return _view.BindingContext is INotifyPropertyChanged notifyPropertyChanged ? notifyPropertyChanged : null;
        }
    }
}
