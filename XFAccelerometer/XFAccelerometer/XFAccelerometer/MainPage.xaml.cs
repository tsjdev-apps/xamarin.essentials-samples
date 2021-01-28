using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFAccelerometer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StartButtonOnClicked(object sender, System.EventArgs e)
        {
            if (Accelerometer.IsMonitoring)
                return;

            try
            {
                Accelerometer.ReadingChanged += OnReadingChanged;
                Accelerometer.Start(SensorSpeed.UI);

                StartButton.IsEnabled = false;
                StopButton.IsEnabled = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"{ex}");
            }
        }

        private void OnReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            LabelX.Text = $"X: {e.Reading.Acceleration.X}";
            LabelY.Text = $"Y: {e.Reading.Acceleration.Y}";
            LabelZ.Text = $"Z: {e.Reading.Acceleration.Z}";
        }

        private void StopButtonOnClicked(object sender, EventArgs e)
        {
            if (!Accelerometer.IsMonitoring)
                return;

            try
            {
                Accelerometer.ReadingChanged -= OnReadingChanged;
                Accelerometer.Stop();

                LabelX.Text = LabelY.Text = LabelZ.Text = "";

                StartButton.IsEnabled = true;
                StopButton.IsEnabled = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex}");
            }
        }
    }
}
