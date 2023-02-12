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
    public partial class HistoryManager : Form
    {
        public HistoryManager()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManager_Load(object sender, EventArgs e)
        {
            var history = HistoryManager.GetItems();


        }
    }
}
