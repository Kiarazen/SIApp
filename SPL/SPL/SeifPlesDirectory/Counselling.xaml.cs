﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.SeifPlesDirectory
{
    public partial class Counselling : ContentPage
    {
        public Counselling()
        {
            InitializeComponent();
        }

        private void RemoveAndChange(object sender, EventArgs e)
        {
            stacklayout.Children.Remove(button);
            text.Children.Add(new Label { Text = "Go to Family Support Centre on 20619/26999", TextColor = Color.Black, HorizontalTextAlignment=TextAlignment.Center });
            furtherText.Children.Add(new Label { Text = "Call counselling service on 7834922", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });
            moreText.Children.Add(new Label { Text = "Need further assistance? Call 132 (24 hours, 7 days a week)", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });
        }

        async void NextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Lawyer()));
        }
    }
}