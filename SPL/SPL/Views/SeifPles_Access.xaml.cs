using System;
using System.Collections.Generic;
using SPL.SeifPlesDirectory;

using Xamarin.Forms;

namespace SPL.Views
{
    public partial class SeifPles_Access : ContentPage
    {
        public SeifPles_Access()
        {
            InitializeComponent();
        }


        async void ToDanger(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Danger()));
        }
    }
}
