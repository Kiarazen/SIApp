using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL.Views;
namespace SPL.Directory
{
    public partial class Education : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Education()
        {
            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Education",
                Info = "Support services for the disabled",
                ImageSource = "learn.jpg"
            });

            Results.Add(new Results
            {
                Name = "School Fee Remission",
                Info = "Help those around you in need",
                ImageSource = "school.jpg"
            });


            BindingContext = this;
        }

        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Education"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new EducationPage()));
            }
            else if (selectedItem.Name.Equals("School Fee Remission"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new School()));
            }
           
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
