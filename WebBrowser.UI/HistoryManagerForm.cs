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
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("[{0}] {1} {2}", item.Date, item.Title, item.URL));
            }
        }

        //User enters a pharse and searchs history items for keyword.
        private void searchButton_Click(object sender, EventArgs e)
        {
            //if user has no input, load history items
            if (searchTermBox.Text.Equals(""))
            {
                HistoryManagerForm_Load(sender, e);
            }

            else
            {
                listBox1.Items.Clear();
                var history = HistoryManager.GetItems();
                foreach (var item in history)
                {
                    if (item.ToString().ToUpper().Contains(searchTermBox.Text.ToUpper()))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
