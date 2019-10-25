using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL.Views;
using SPL;
namespace SPL.Directory
{
    public partial class HealthMenu : ContentPage
    {
        public HealthMenu()
        {
            InitializeComponent();
        }

        async void GoBack(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HomePage()));
        }


        async void GoNext(object sender, EventArgs e)
        {
            if (checkbox1.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new Mental()));
            }
            else if (checkbox2.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new Womens()));
            }
            else if (checkbox3.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new Childrens()));
            }
            else if (checkbox4.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new Hospitals()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
