using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFDeviceDisplay
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
		}

		private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
		{
			UpdateDeviceDisplayData();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			UpdateDeviceDisplayData();
		}

		private void UpdateDeviceDisplayData()
		{
			var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

			OrientationLabel.Text = mainDisplayInfo.Orientation.ToString();
			RotationLabel.Text = mainDisplayInfo.Rotation.ToString();
			WidthLabel.Text = mainDisplayInfo.Width.ToString();
			HeightLabel.Text = mainDisplayInfo.Height.ToString();
			DensityLabel.Text = mainDisplayInfo.Density.ToString();
			RefreshRateLabel.Text = mainDisplayInfo.RefreshRate.ToString();
		}
	}
}
