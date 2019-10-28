using System;
using System.Collections.Generic;
using SPL.Views;
using Xamarin.Forms;

namespace SPL.Directory
{
    public partial class Women : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Women()
        {

            InitializeComponent();

            Results.Add(new Results
            {
                Name = "SI Planned Parenthood",
                Info = "Family planning and related services clinic",
                ImageSource = "SIPPA.jpg"
            });

            Results.Add(new Results
            {
                Name = "Family Support Centre",
                Info = "Family Support and Counselling Services",
                ImageSource = "FSC.jpg"
            });

            Results.Add(new Results
            {
                Name = "Christian Care Centre",
                Info = "Support for women and children who have been victims of violence",
                ImageSource = "CCC.jpg"
            });

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

            Results.Add(new Results
            {
                Name = "Victim Response",
                Info = "Support and counselling for victims under social welfare scheme",
                ImageSource = "victim.jpg"
            });



            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("SI Planned Parenthood"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new SIPPAPage()));
            }
            else if (selectedItem.Name.Equals("Family Support Centre"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new FSCPage()));
            }
            else if (selectedItem.Name.Equals("Christian Care Centre"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CCCPage()));
            }
            else if (selectedItem.Name.Equals("Health Sector Welfare"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new HealthcarePage()));
            }
            else if (selectedItem.Name.Equals("SafeNet & Seif Ples"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new SafeNet()));
            }
            else if (selectedItem.Name.Equals("Victim Response"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new VictimResponse()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));
        }
    }
}