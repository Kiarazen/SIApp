using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL
{
    public partial class SafeNetMembers : ContentPage
    {
        public SafeNetMembers()
        {
            InitializeComponent();
        }

        async void ToFSC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FSCPage()));
        }

        async void ToCCC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CCCPage()));
        }

        async void ToNRH_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NRHPage()));
        }

        async void ToSIPPA_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SIPPAPage()));
        }

        async void ToRSPIF_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RSPIF_Page()));
        }

        async void ToOthers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OthersPage()));
        }
    }
}
