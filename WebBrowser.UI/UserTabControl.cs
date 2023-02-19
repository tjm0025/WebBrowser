using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBroswer.Logic;

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

        //Adds Url to the history table in the database
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.AbsoluteUri == e.Url.AbsoluteUri)
            {
                var item = new HistoryItem();
                item.URL = addressTextBox.Text;
                item.Title = webBrowser1.DocumentTitle;
                item.Date = DateTime.Now.ToString("mm/dd/yyyy HH:mm:ss");

                HistoryManager.AddItem(item);

            }
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

        //Navigates webBrowser1 to home page.
        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
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

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            var bookmarks = BookmarkManager.GetItems();
            var bookmarkExists = false;
            //Check and see if the bookmark already exists for that page
            foreach ( var bookmark in bookmarks )
            {
                if (bookmark.URL == webBrowser1.Url.ToString())
                {
                    bookmarkExists = true;
                }
            }
            //Add the bookmark if it doesn't already exist
            if (!bookmarkExists)
            {
                var bookmark = new BookmarkItem();
                bookmark.Title = webBrowser1.DocumentTitle;
                bookmark.URL = webBrowser1.Url.ToString();
                BookmarkManager.AddItem(bookmark);
            }
           


        }
    }
}
