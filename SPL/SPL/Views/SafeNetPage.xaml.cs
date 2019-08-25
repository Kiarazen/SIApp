using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SafeNetPage : ContentPage
    {
        public SafeNetPage()
        {
            InitializeComponent();
        }

        async void ToSafeAbout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SafeAboutPage()));
        }
    }
}