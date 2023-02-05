using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UserTabControl : UserControl
    {
        public UserTabControl()
        {
            InitializeComponent();
        }

        //Navigates webBrowser1 to previous page.
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //Stops the back button at beginning of nav history.
        //This is just a test place holder until I can set up a better method
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            backButton.Enabled = webBrowser1.CanGoBack;
        }


        private void fowardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }


        //Reloads the current page in browser
        private void refreshButton_Click(object sender, EventArgs e)
        {
            //Skip the refresh if about:blank is loaded
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(addressTextBox.Text);
            }
        }
        private void addressTextBox_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Navigate(addressTextBox.Text);
        }


        //Allows webbrowser 1 to navigate to a given URL if valid.
        //Referenced https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.webbrowser.url?view=windowsdesktop-7.0
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

       
    }
}
