using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFSms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SMSButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                var message = new SmsMessage(MessageBodyEntry.Text, RecipientEntry.Text);
                await Sms.ComposeAsync(message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"{GetType().Name} | {nameof(SMSButtonOnClicked)} | {ex}");
            } 
        }
    }
}
