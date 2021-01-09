using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFAppInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void OpenSettingsButtonOnClicked(object sender, EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}