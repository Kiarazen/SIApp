
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SPL
{
    public partial class VideosPage : ContentPage
    {
        public VideosPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }
    }
}



