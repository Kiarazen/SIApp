using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.SeifPlesDirectory
{
    public partial class Injured : ContentPage
    {
        public Injured()
        {
            InitializeComponent();
        }

        private void RemoveAndChange(object sender, EventArgs e)
        {
            stacklayout.Children.Remove(button);
            text.Children.Add(new Label { Text = "Bring person to Seif Ples Clinic, Rove", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });
            moreText.Children.Add(new Label { Text = "Need further assistance? Call 132 (24 hours, 7 days a week)", TextColor = Color.Black, HorizontalTextAlignment=TextAlignment.Center });
        }

        async void NextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Shock()));
        }
    }
}
