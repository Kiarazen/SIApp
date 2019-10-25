using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HaveSay : ContentPage
    {
        public HaveSay()
        {
            InitializeComponent();
        }
        async void ToFeedback_P1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FeedbackP1()));
        }
    }
}