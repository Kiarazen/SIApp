using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.Views
{
    public partial class FeedbackP1 : ContentPage
    {
        public FeedbackP1()
        {
            InitializeComponent();
        }

        async void ToPage2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FeedbackP2()));
        }
    }
}
