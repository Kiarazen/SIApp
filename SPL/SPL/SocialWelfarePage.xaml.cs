using System;
using System.Collections.Generic;
using SPL.Directory;
using Xamarin.Forms;
using SPL.Views;
namespace SPL
{
    public partial class SocialWelfarePage : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public SocialWelfarePage()
        {

            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Crisis Assistance",
                ImageSource = "crisis.jpg"
            });

            Results.Add(new Results
            {
                Name = "Victim Response",
                ImageSource = "victim.jpg"
            });


            Results.Add(new Results
            {
                Name = "Child Protection",
                ImageSource = "child.jpg"
            });

            Results.Add(new Results
            {
                Name = "Family Support",
                ImageSource = "family.jpg"
            });

            Results.Add(new Results
            {
                Name = "Adoption",
                ImageSource = "adoption.jpg"
            });

            Results.Add(new Results
            {
                Name = "School Fee Remission",
                ImageSource = "school.jpg"
            });

            Results.Add(new Results
            {
                Name = "Family Court",
                ImageSource = "family_court.jpg"
            });

            Results.Add(new Results
            {
                Name = "Juvenile Court",
                ImageSource = "juvenile_court.jpg"
            });

            Results.Add(new Results
            {
                Name = "Probation",
                ImageSource = "probation.jpg"
            });

            Results.Add(new Results
            {
                Name = "Prisoner and Family",
                ImageSource = "prisoner.jpg"
            });

            Results.Add(new Results
            {
                Name = "Health Sector Welfare",
                ImageSource = "health_sector.jpg"
            });

            Results.Add(new Results
            {
                Name = "Volunteer Scheme",
                ImageSource = "volunteer.jpg"
            });

            Results.Add(new Results
            {
                Name = "Declaration Letters",
                ImageSource = "letters.jpg"
            });

            Results.Add(new Results
            {
                Name = "Other Services",
                ImageSource = "other_welfare.jpg"
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
            else if (selectedItem.Name.Equals("Child Protection"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new ChildProtect()));
            }
            else if (selectedItem.Name.Equals("Family Support"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new FamilySupport()));
            }
            else if (selectedItem.Name.Equals("Adoption"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new Adoption()));
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
