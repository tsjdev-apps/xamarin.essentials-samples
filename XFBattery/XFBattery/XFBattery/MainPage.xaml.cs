using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFBattery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Battery.BatteryInfoChanged += OnBatteryInfoChanged;
            Battery.EnergySaverStatusChanged += OnEnergySaverStatusChanged;

            BatteryLevelLabel.Text = Battery.ChargeLevel.ToString();
            BatteryStateLabel.Text = Battery.State.ToString();
            BatteryPowerSourceLabel.Text = Battery.PowerSource.ToString();
            EnergySaverStateLabel.Text = Battery.EnergySaverStatus.ToString();
        }

        private void OnEnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            EnergySaverStateLabel.Text = e.EnergySaverStatus.ToString();
        }

        private void OnBatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            BatteryLevelLabel.Text = e.ChargeLevel.ToString();
            BatteryStateLabel.Text = e.State.ToString();
            BatteryPowerSourceLabel.Text = e.PowerSource.ToString();
        }
    }
}
