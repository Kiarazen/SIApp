﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SPL.Views
{
    public partial class FeedbackP3 : ContentPage
    {
        public FeedbackP3()
        {
            InitializeComponent();


        }

        async void Rate(object sender, EventArgs e)
        {
            Image image = sender as Image;
            string source = image.Source as FileImageSource;  //Getting the name of source as string
            if (String.Equals(source, "empty.png"))
            {
                image.Source = "full.png";
            }
            else
            {
                image.Source = "empty.png";
            }
        }
    }
}