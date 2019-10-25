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
            await Navigation.PushModalAsync(new NavigationPage(new AboutSafeNet()));
        }
        
        async void ToMembers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SafeNetMembers()));
        }

        async void ToWhere_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SafeNetWhere()));
        }

        async void ToAccess_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SeifPles_Access()));
        }
    }
}