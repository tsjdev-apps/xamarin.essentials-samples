using System;
using System.Diagnostics;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFContacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetContactButtonOnClicked(object sender, System.EventArgs e)
        {
            try
            {
                var contact = await Contacts.PickContactAsync();

                if (contact == null)
                    return;

                IdLabel.Text = contact.Id;
                GivenNameLabel.Text = contact.GivenName;
                MiddleNameLabel.Text = contact.MiddleName;
                FamilyNameLabel.Text = contact.FamilyName;
                DisplayNameLabel.Text = contact.DisplayName;
                PhonesLabel.Text = string.Join(", ", contact.Phones.Select(x => x.PhoneNumber));
                EmailsLabel.Text = string.Join(", ", contact.Emails.Select(x => x.EmailAddress));
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"{GetType().Name} | {nameof(GetContactButtonOnClicked)} | {ex}");
            }
        }
    }
}
