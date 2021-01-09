using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFPreferences
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private readonly string PreferencesKey = "MyPreferencesKey";

        private void SaveValueButtonOnClicked(object sender, EventArgs e)
        {
            Preferences.Set(PreferencesKey, PreferencesValueEntry.Text);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            PreferencesValueEntry.Text
                = Preferences.Get(PreferencesKey, "Default Value");
        }
    }
}
