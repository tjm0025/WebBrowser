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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        //Exits the browser based on user prompt
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Displays about information from Help button
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser was developed by Tyanna Malone for CPSC 2710." +
                "\n Student ID: 903204366");
        }

       
       

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        /**Navigates to URL in address text box when Enter is clicked
        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                Navigate(addressTextBox.Text);
            }
        }
        **/

       /**Navigates to URL in address text box when Go is clicked by User
        private void goButton_Click(object sender, EventArgs e)
        {
            Navigate(addressTextBox.Text);
        }
       **/
        

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
        //Uses TabPages Collection to allow user to create new tab
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTabPage= new TabPage("New Tab"); //creates the new tab
            tabControl1.TabPages.Add(myTabPage); //adds the tab to tabcontrol

            UserTabControl myUserTabControl = new UserTabControl();
            myUserTabControl.Dock= DockStyle.Fill;
            myTabPage.Controls.Add(myUserTabControl);
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab); //Removes selected tab
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new HistoryManagerForm();
            itemsForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemsForm = new BookmarkManagerForm();
            itemsForm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
        }
    }
}
