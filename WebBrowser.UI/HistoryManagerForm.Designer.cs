namespace WebBrowser.UI
{
    partial class HistoryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.historyItemBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTermBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearHisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyItemBox
            // 
            this.historyItemBox.FormattingEnabled = true;
            this.historyItemBox.ItemHeight = 25;
            this.historyItemBox.Location = new System.Drawing.Point(28, 27);
            this.historyItemBox.Margin = new System.Windows.Forms.Padding(6);
            this.historyItemBox.Name = "historyItemBox";
            this.historyItemBox.Size = new System.Drawing.Size(1114, 629);
            this.historyItemBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(391, 680);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(193, 44);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTermBox
            // 
            this.searchTermBox.Location = new System.Drawing.Point(39, 687);
            this.searchTermBox.Name = "searchTermBox";
            this.searchTermBox.Size = new System.Drawing.Size(322, 31);
            this.searchTermBox.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(636, 680);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(193, 44);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearHisButton
            // 
            this.clearHisButton.Location = new System.Drawing.Point(870, 680);
            this.clearHisButton.Name = "clearHisButton";
            this.clearHisButton.Size = new System.Drawing.Size(193, 44);
            this.clearHisButton.TabIndex = 4;
            this.clearHisButton.Text = "Clear History";
            this.clearHisButton.UseVisualStyleBackColor = true;
            this.clearHisButton.Click += new System.EventHandler(this.clearHisButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.clearHisButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchTermBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.historyItemBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyItemBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTermBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearHisButton;
    }
}