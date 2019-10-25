using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.Views
{
    public partial class FeedbackP2 : ContentPage
    {
        public FeedbackP2()
        {
            InitializeComponent();
        }

        async void ToPage3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FeedbackP3()));
        }
    }
}
