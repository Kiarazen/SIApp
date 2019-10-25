﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnPage : ContentPage
    {
        public LearnPage()
        {
            InitializeComponent();
        }

        async void ToVideos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new VideosPage()));
        }
    }
}