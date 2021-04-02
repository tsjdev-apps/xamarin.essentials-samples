using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFClipboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SetClipboardButtonOnClicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(ClipboardEntry.Text);
        }

        private async void GetClipboardButtonOnClicked(object sender, EventArgs e)
        {
            ClipboardLabel.Text = await Clipboard.GetTextAsync();
        }
    }
}
