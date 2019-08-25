using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SPL.ViewModels
{
    public class SafeAboutView : BaseViewModel
    {
        public SafeAboutView()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://safenetservices.org/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}