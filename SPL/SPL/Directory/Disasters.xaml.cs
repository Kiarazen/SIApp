using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL.Views;
namespace SPL.Directory
{
    public partial class Disasters : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Disasters()
        {
            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Disasters",
                Info = "Support services for the disabled",
                ImageSource = "SIdisaster.jpg"
            });

            Results.Add(new Results
            {
                Name = "Crisis Assistance",
                Info = "Provision of emergency assistance in times of need",
                ImageSource = "crisis.jpg"
            });


            BindingContext = this;
        }

        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Disasters"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new DisabilitiesPage()));
            }
            else if (selectedItem.Name.Equals("Crisis Assistance"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CrisisAssistancePage()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
