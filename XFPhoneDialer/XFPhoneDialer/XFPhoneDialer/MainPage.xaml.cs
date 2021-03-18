using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFPhoneDialer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CallButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(PhoneNumberEntry.Text);
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
