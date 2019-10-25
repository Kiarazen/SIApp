using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.SeifPlesDirectory
{
    public partial class Danger : ContentPage
    {
        public Danger()
        {
            InitializeComponent();
        }

        private void RemoveAndChange(object sender, EventArgs e)
        {
            stacklayout.Children.Remove(button);
            text.Children.Add(new Label { Text = "Exit this app. Call 999 now.", TextColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center });

        }

        async void NextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Injured()));
        }
    }
}