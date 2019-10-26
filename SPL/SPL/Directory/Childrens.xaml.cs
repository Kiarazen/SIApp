using System;
using System.Collections.Generic;
using SPL.Views;
using Xamarin.Forms;

namespace SPL.Directory
{
    public partial class Childrens : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Childrens()
        {

            InitializeComponent();

            Results.Add(new Results
            {
                Name = "Child Protection",
                Info = "Services to ensure child wellbeing",
                ImageSource = "child.jpg"
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

            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Child Protection"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new ChildProtect()));
            }
            else if (selectedItem.Name.Equals("Christian Care Centre"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CCCPage()));
            }
            else if (selectedItem.Name.Equals("Health Sector Welfare"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new HealthcarePage()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
