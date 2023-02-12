namespace WebBrowser.UI
{
    partial class HistoryManager
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
            this.HistoryManagerForm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HistoryManagerForm
            // 
            this.HistoryManagerForm.FormattingEnabled = true;
            this.HistoryManagerForm.Location = new System.Drawing.Point(12, 12);
            this.HistoryManagerForm.Name = "HistoryManagerForm";
            this.HistoryManagerForm.Size = new System.Drawing.Size(558, 303);
            this.HistoryManagerForm.TabIndex = 0;
            this.HistoryManagerForm.SelectedIndexChanged += new System.EventHandler(this.HistoryManagerForm_SelectedIndexChanged);
            // 
            // HistoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HistoryManagerForm);
            this.Name = "HistoryManager";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryManagerForm;
    }
}