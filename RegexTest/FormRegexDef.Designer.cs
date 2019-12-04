namespace RegexTest
{
    partial class FormRegexDef
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
            this.webBrowserRegex = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserRegex
            // 
            this.webBrowserRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserRegex.Location = new System.Drawing.Point(0, 0);
            this.webBrowserRegex.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRegex.Name = "webBrowserRegex";
            this.webBrowserRegex.Size = new System.Drawing.Size(800, 450);
            this.webBrowserRegex.TabIndex = 0;
            // 
            // FormRegexDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserRegex);
            this.Name = "FormRegexDef";
            this.Text = "Regex Definition ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserRegex;
    }
}