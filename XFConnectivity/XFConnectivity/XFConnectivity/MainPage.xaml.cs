using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFConnectivity
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

            Connectivity.ConnectivityChanged += OnConnectivityChanged;

            NetworkAccessLabel.Text = Connectivity.NetworkAccess.ToString();
            ConnectionProfilesLabel.Text = string.Join(", ", Connectivity.ConnectionProfiles);
        }

        private void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            NetworkAccessLabel.Text = e.NetworkAccess.ToString();
            ConnectionProfilesLabel.Text = string.Join(", ", e.ConnectionProfiles);
        }
    }
}
