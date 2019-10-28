using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL.Views;
using SPL;
namespace SPL.Directory
{
    public partial class Disabilities : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Disabilities()
        {
            InitializeComponent();


            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Disabilities",
                Info = "Support services for the disabled",
                ImageSource = "disabled.jpg"
            });

            Results.Add(new Results
            {
                Name = "Volunteer Scheme",
                Info = "Help those around you in need",
                ImageSource = "volunteer.jpg"
            });


            BindingContext = this;

        }

        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Disabilities"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new DisabilitiesPage()));
            }
            else if (selectedItem.Name.Equals("Volunteer Scheme"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new Volunteer()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
