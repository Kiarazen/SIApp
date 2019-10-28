using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace SPL.Views
{
    public partial class FeedbackP3 : ContentPage
    {
        public FeedbackP3()
        {
            InitializeComponent();
        }


        private void Rate1(object sender, EventArgs e)
        {

            string source = oneStar.Source as FileImageSource;

            if (String.Equals(source, "empty1.png"))
            {
                oneStar.Source = "full1.png";
            }
            else
            {
                oneStar.Source = "empty1.png";
            }
        }

        private void Rate2(object sender, EventArgs e)
        {
            string source2 = twoStar.Source as FileImageSource;

            if (String.Equals(source2, "empty1.png"))
            {
                oneStar.Source = "full1.png";
                twoStar.Source = "full1.png";
            }
            else
            {
                oneStar.Source = "empty1.png";
                twoStar.Source = "empty1.png";
            }
        }

        private void Rate3(object sender, EventArgs e)
        {
            string source3 = threeStar.Source as FileImageSource;

            if (String.Equals(source3, "empty1.png"))
            {
                oneStar.Source = "full1.png";
                twoStar.Source = "full1.png";
                threeStar.Source = "full1.png";
            }
            else
            {
                oneStar.Source = "empty1.png";
                twoStar.Source = "empty1.png";
                threeStar.Source = "empty1.png";
            }
        }

        private void Rate4(object sender, EventArgs e)
        {
            string source4 = fourStar.Source as FileImageSource;

            if (String.Equals(source4, "empty1.png"))
            {
                oneStar.Source = "full1.png";
                twoStar.Source = "full1.png";
                threeStar.Source = "full1.png";
                fourStar.Source = "full1.png";
            }
            else
            {
                oneStar.Source = "empty1.png";
                twoStar.Source = "empty1.png";
                threeStar.Source = "empty1.png";
                fourStar.Source = "empty1.png";
            }
        }

        private void Rate5(object sender, EventArgs e)
        {
            string source5 = fiveStar.Source as FileImageSource;

            if (String.Equals(source5, "empty1.png"))
            {
                oneStar.Source = "full1.png";
                twoStar.Source = "full1.png";
                threeStar.Source = "full1.png";
                fourStar.Source = "full1.png";
                fiveStar.Source = "full1.png";
            }
            else
            {


                oneStar.Source = "empty1.png";
                twoStar.Source = "empty1.png";
                threeStar.Source = "empty1.png";
                fourStar.Source = "empty1.png";
                fiveStar.Source = "empty1.png";
            }
        }



        async void BackToHome(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Submit?", "Would you like to submit your feedback", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);

            if (answer) await this.Navigation.PushAsync(new HomePage());



        }

    }
}