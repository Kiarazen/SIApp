using System;
using System.Collections.Generic;
using SPL.Directory;
using Xamarin.Forms;
using SPL.Views;
namespace SPL
{
    public partial class Members : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Members()
        {

            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "FSC",
                Info="Family Crisis Centre",
                ImageSource = "FSC.jpg"
            });

            Results.Add(new Results
            {
                Name = "CCC",
                Info = "Christian Care Centre",
                ImageSource = "CCC.jpg"
            });


            Results.Add(new Results
            {
                Name = "RSIPF",
                Info = "Royal Solomon Islands Police Force",
                ImageSource = "RSIPF.jpg"
            });

            Results.Add(new Results
            {
                Name = "SIPPA",
                Info = "Solomon Islands Planned Parenthood Association",
                ImageSource = "SIPPA.jpg"
            });

            Results.Add(new Results
            {
                Name = "NRH",
                Info = "National Referral Hospital",
                ImageSource = "NRH.jpg"
            });

            Results.Add(new Results
            {
                Name = "Others",
                Info = "Miscellaneous Services",
                ImageSource = "others.jpg"
            });

           

            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("FSC"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new FSCPage()));
            }
            else if (selectedItem.Name.Equals("CCC"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new CCCPage()));
            }
            else if (selectedItem.Name.Equals("RSIPF"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new RSPIF_Page()));
            }
            else if (selectedItem.Name.Equals("SIPPA"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new SIPPAPage()));
            }
            else if (selectedItem.Name.Equals("NRH"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new NRHPage()));
            }
            else if (selectedItem.Name.Equals("Others"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new OthersPage()));
            }

            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}

