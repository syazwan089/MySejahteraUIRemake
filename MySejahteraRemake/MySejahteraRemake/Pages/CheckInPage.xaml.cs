using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySejahteraRemake.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckInPage : ContentView
    {
        public CheckInPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckInResultPage());
        }
    }
}