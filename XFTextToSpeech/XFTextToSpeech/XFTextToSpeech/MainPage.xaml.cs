using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFTextToSpeech
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void SpeakButtonOnClicked(object sender, System.EventArgs e)
		{
			var textToSpeech = TextEntry.Text;
			if (string.IsNullOrEmpty(textToSpeech))
				return;

			var settings = new SpeechOptions { Volume = .75f, Pitch = .5f };

			var locales = await TextToSpeech.GetLocalesAsync();
			var germanLocale = locales.FirstOrDefault(l => l.Language == "de-DE");

			if (germanLocale != null)
				settings.Locale = germanLocale;

			await TextToSpeech.SpeakAsync(textToSpeech, settings);
		}
	}
}
