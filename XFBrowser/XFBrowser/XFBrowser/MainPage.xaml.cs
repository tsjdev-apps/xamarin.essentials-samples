using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFBrowser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenWebsiteButtonOnClicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.tsjdev-apps.de");
        }
    }
}
