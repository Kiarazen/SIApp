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
    public partial class SocProtPage : ContentPage
    {
        public SocProtPage()
        {
            InitializeComponent();
        }


        async void ToSocialWelfare_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SocialWelfarePage()));
        }

        async void ToSafeNet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SafeNetPage()));
        }

        async void ToDisabilities_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DisabilitiesPage()));
        }

        async void ToDisasters_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DisastersPage()));
        }

        async void ToHealthcare_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HealthcarePage()));
        }

        async void ToEducation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new EducationPage()));
        }
    }
}