﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace SPL.Views
{
    public partial class AboutSafeNet : ContentPage
    {
        public AboutSafeNet()
        {
            InitializeComponent();
        }

        async void ToWomen(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SafeNetWomen()));
        }
    }
}
