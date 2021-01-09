using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFMail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SendMailButtonOnClicked(object sender, System.EventArgs e)
        {
            try
            {
                var message = new EmailMessage
                {
                    To = new List<string> { ToEntry.Text },
                    Subject = SubjectEntry.Text,
                    Body = BodyEntry.Text
                };

                if (!string.IsNullOrEmpty(CcEntry.Text))
                    message.Cc = new List<string> { CcEntry.Text };

                if (!string.IsNullOrEmpty(BccEntry.Text))
                    message.Bcc = new List<string> { BccEntry.Text };

                var filename = "attachment.txt";
                var file = Path.Combine(FileSystem.CacheDirectory, filename);
                File.WriteAllText(file, "Hello World!");

                message.Attachments.Add(new EmailAttachment(file));

                await Email.ComposeAsync(message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"{GetType().Name} | {nameof(SendMailButtonOnClicked)} | {ex}");
            }
        }
    }
}
