using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL;
using SPL.Views;
namespace SPL.Directory
{
    public partial class Families : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Families()
        {
            InitializeComponent();


            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Family Support",
                Info = "Support for family matters",
                ImageSource = "family.jpg"
            });

            Results.Add(new Results
            {
                Name = "Child Protection",
                Info = "Services to ensure child wellbeing",
                ImageSource = "child.jpg"
            });


            Results.Add(new Results
            {
                Name = "Adoption",
                Info = "Information on the process of adoption",
                ImageSource = "adoption.jpg"
            });

            Results.Add(new Results
            {
                Name = "School Fee Remission",
                Info = "Ensuring each child has access to education",
                ImageSource = "school.jpg"
            });

            Results.Add(new Results
            {
                Name = "Family Support Centre",
                Info = "Family support and counselling services",
                ImageSource = "FSC.jpg"
            });

            BindingContext = this;

        }

        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Family Support"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new FamilySupport()));
            }
            else if (selectedItem.Name.Equals("Child Protection"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new ChildProtect()));
            }
            else if (selectedItem.Name.Equals("Adoption"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new Adoption()));
            }
            else if (selectedItem.Name.Equals("School Fee Remission"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new School()));
            }
            else if (selectedItem.Name.Equals("Family Support Centre"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new FSCPage()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
