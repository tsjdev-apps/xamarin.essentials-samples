using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFFlashlight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void FlashlightOnButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();

                FlashlightOnButton.IsEnabled = false;
                FlashlightOffButton.IsEnabled = true;
            }
            catch
            {
                FlashlightOnButton.IsEnabled = true;
                FlashlightOffButton.IsEnabled = false;
            }
        }

        private async void FlashlightOffButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOffAsync();

                FlashlightOnButton.IsEnabled = true;
                FlashlightOffButton.IsEnabled = false;
            }
            catch
            {
                FlashlightOnButton.IsEnabled = false;
                FlashlightOffButton.IsEnabled = true;
            }
        }
    }
}
