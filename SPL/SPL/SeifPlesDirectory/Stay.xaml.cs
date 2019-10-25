using System;
using System.Collections.Generic;
using SPL.Views;

using Xamarin.Forms;

namespace SPL.SeifPlesDirectory
{
    public partial class Stay : ContentPage
    {
        public Stay()
        {
            InitializeComponent();
        }

        private void RemoveAndChange(object sender, EventArgs e)
        {
            stacklayout.Children.Remove(button);
            text.Children.Add(new Label { Text = "Take person to Christian Care Centre 7651222 (long term stays) or Seif Ples (overnight accomodation only)", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });
            moreText.Children.Add(new Label { Text = "Need further assistance? Call 132 (24 hours, 7 days a week)", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });
        }

        async void NextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HomePage()));
        }
    }
}
