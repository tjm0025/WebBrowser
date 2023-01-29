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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser was developed by Tyanna Malone for CPSC 2710." +
                "\n Student ID: 903204366");
        }

        private void addressBox_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBox.SelectedItem.ToString());
        }
    }
}
