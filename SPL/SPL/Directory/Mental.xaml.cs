using System;
using System.Collections.Generic;
using SPL.Views;
using Xamarin.Forms;

namespace SPL.Directory
{
    public partial class Mental : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Mental()
        {

            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Health Sector Welfare",
                Info = "Provision of emergency or outpatient mental health support",
                ImageSource = "health_sector.jpg"
            });

            Results.Add(new Results
            {
                Name = "SafeNet & Seif Ples",
                Info = "Counselling and psychosocial services are available",
                ImageSource = "safep.jpg"
            });


           


            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Health Sector Welfare"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CrisisAssistancePage()));
            }
            else if (selectedItem.Name.Equals("SafeNet & Safe Ples"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new SafeNet()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
