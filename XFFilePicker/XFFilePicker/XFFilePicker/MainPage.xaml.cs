using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFFilePicker
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void PickFileButtonOnClicked(object sender, System.EventArgs e)
		{
			try
			{
				var options = new PickOptions { PickerTitle = "Pick a file" };
				var fileResult = await FilePicker.PickAsync(options);

				if (fileResult == null)
					return;

				FileNameLabel.Text = fileResult.FileName;
			}
			catch(Exception ex)
			{
				Debug.WriteLine($"{GetType().Name} | {nameof(PickFileButtonOnClicked)} | {ex}");
			}
		}
	}
}
