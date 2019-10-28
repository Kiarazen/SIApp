using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SPL.Views;
namespace SPL.Directory
{
    public partial class Awareness : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Awareness()
        {
            InitializeComponent();

            Results = new List<Results>();
            Results.Add(new Results
            {
                Name = "Awareness Materials",
                Info = "Videos, Podcasts and a Quiz to test your knowledge of social protections",
                ImageSource = "video.jpg"
            });

          


            BindingContext = this;
        }

        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Awareness Materials"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new LearnPage()));
            }
            
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
