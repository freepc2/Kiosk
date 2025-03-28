using Paul.Maui.Controls;
using System.ComponentModel;
using Paul.Maui.Composition;

namespace Kiosk.Views
{
    public partial class MainPage : MauiContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
