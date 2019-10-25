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

        async void ToChild_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ChildProtect()));
        }

        async void ToVictim_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new VictimResponse()));
        }

        async void ToFamily_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FamilySupport()));
        }

        async void ToAdoption_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Adoption()));
        }

        async void ToSchool_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new School()));
        }
    }
}
