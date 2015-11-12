namespace OperationsWorkbench
{
    partial class Form3
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
            this.OpsBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // OpsBrowser
            // 
            this.OpsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpsBrowser.Location = new System.Drawing.Point(0, 0);
            this.OpsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.OpsBrowser.Name = "OpsBrowser";
            this.OpsBrowser.Size = new System.Drawing.Size(1148, 428);
            this.OpsBrowser.TabIndex = 0;
            this.OpsBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 428);
            this.Controls.Add(this.OpsBrowser);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser OpsBrowser;
    }
}