﻿using System;
using System.Collections.Generic;
using SPL.Views;
using Xamarin.Forms;

namespace SPL.Directory
{
    public partial class Hospitals : ContentPage
    {
        public IList<Results> Results { get; private set; }

        public Hospitals()
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
                Name = "NRH",
                Info = "National Referral Hospital",
                ImageSource = "NRH.jpg"
            });



            BindingContext = this;
        }


        async void GoToResults(object sender, SelectedItemChangedEventArgs e)
        {

            Results selectedItem = e.SelectedItem as Results;
            if (selectedItem.Name.Equals("Health Sector Welfare"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new HealthcarePage()));
            }
            else if (selectedItem.Name.Equals("NRH"))
            {
                await Navigation.PushModalAsync(new NavigationPage(new NRHPage()));
            }
            else
                await Navigation.PushModalAsync(new NavigationPage(new HomePage()));

        }
    }
}
