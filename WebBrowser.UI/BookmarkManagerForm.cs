using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBroswer.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));

            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //load bookmarks from Bookmark manager
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(searchTextBox.Text) || item.URL.Contains(searchTextBox.Text))
                {
                    bookmarkListBox.Items.Add(item);
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //load bookmark manager items from dtatabase, then use Remove method from Bookmark manager to remove items from listbox.
            var deletehistory = BookmarkManager.GetItems();
            BookmarkManager.RemoveBookmark(deletehistory[bookmarkListBox.SelectedIndex]);
            BookmarkManagerForm_Load(sender, e);
            deleteButton.Enabled = false;
        }
    }
}
