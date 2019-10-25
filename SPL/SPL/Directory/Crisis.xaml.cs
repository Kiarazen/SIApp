using System;
using System.Collections.Generic;
using SPL.Views;

using Xamarin.Forms;

namespace SPL.Directory
{
    public partial class Crisis : ContentPage
    {

        public IList<Results> Results { get; private set; }

        public Crisis()
        {

            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Crisis Assistance",
                Info = "Provision of emergency assistance in times of need",
                ImageSource = "crisis.png"
            });

            Results.Add(new Results
            {
                Name = "Victim Response",
                Info = "Support and counselling for victims under social welfare scheme",
                ImageSource = "victim.png"
            });


            Results.Add(new Results
            {
                Name = "SafeNet & Safe Ples",
                Info = "Support for victims of gender-based violence",
                ImageSource = "safep.png"
            });


            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Crisis Assistance"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CrisisAssistancePage()));
            }
            else if (selectedItem.Name.Equals("Victim Response"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new VictimResponse()));
            }
            else if (selectedItem.Name.Equals("SafeNet & Safe Ples"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new SafeNetPage()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
       


    }
}
