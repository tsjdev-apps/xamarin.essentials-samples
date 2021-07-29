using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFSecureStorage
{
	public partial class MainPage : ContentPage
	{
		private readonly string SecureStorageKey = "MySecureStorageKey";

		public MainPage()
		{
			InitializeComponent();
		}

		private async void SaveValueButtonOnClicked(object sender, EventArgs e)
		{
			await SecureStorage.SetAsync(SecureStorageKey, SecureStorageValueEntry.Text);
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			SecureStorageValueEntry.Text = await SecureStorage.GetAsync(SecureStorageKey)
				?? "No value";
		}
	}
}
