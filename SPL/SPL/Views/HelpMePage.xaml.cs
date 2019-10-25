using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPL.Directory;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPL.Views
{
    
    public partial class HelpMePage : ContentPage
    {
        public HelpMePage()
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
                await Navigation.PushModalAsync(new NavigationPage(new Crisis()));
            }
            else if (checkbox2.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new Families()));
            }
            else if (checkbox3.IsChecked)
            {
                await Navigation.PushModalAsync(new NavigationPage(new HealthMenu()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }


       

    }
}