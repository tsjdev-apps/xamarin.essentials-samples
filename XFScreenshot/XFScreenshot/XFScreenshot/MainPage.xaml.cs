using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFScreenshot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ScreenshotButtonOnClicked(object sender, System.EventArgs e)
        {
            var screenshot = await Screenshot.CaptureAsync();
            var stream = await screenshot.OpenReadAsync();

            ScreenshotImage.Source = ImageSource.FromStream(() => stream);
        }
    }
}
