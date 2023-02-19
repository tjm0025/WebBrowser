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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyItemBox.Items.Clear();

            foreach (var item in items)
            {
                historyItemBox.Items.Add(string.Format("[{0}] {1} {2}", item.Date, item.Title, item.URL));
            }
        }

        //User enters a pharse and searchs history items for keyword.
        private void searchButton_Click(object sender, EventArgs e)
        {
            //load history items from manager
            var items = HistoryManager.GetItems();

           historyItemBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(searchTermBox.Text) || item.URL.Contains(searchTermBox.Text))
                {
                    historyItemBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
