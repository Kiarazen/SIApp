using System;
using System.Collections.Generic;
using SPL;
using Xamarin.Forms;

namespace SPL.Views
{
    public partial class SafeNet : ContentPage
    {
        public SafeNet()
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
