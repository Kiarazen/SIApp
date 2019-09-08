using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL
{
    public partial class SocialWelfarePage : ContentPage
    {
        public SocialWelfarePage()
        {
            InitializeComponent();
        }

        async void ToCrisis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CrisisAssistancePage()));
        }
    }
}
