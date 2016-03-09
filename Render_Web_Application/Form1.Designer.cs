namespace Render_Web_Application
{
    partial class frmMainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ffMainBrowser = new Skybound.Gecko.GeckoWebBrowser();
            this.htmlControl1 = new Library.user.control.HtmlControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ffMainBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.htmlControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 588);
            this.splitContainer1.SplitterDistance = 970;
            this.splitContainer1.TabIndex = 0;
            // 
            // ffMainBrowser
            // 
            this.ffMainBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ffMainBrowser.Location = new System.Drawing.Point(0, 0);
            this.ffMainBrowser.Name = "ffMainBrowser";
            this.ffMainBrowser.Size = new System.Drawing.Size(970, 588);
            this.ffMainBrowser.TabIndex = 1;
            this.ffMainBrowser.DomClick += new Skybound.Gecko.GeckoDomEventHandler(this.ffMainBrowser_DomClick);
            // 
            // htmlControl1
            // 
            this.htmlControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlControl1.BackColor = System.Drawing.Color.DarkOrange;
            this.htmlControl1.Location = new System.Drawing.Point(3, 6);
            this.htmlControl1.Name = "htmlControl1";
            this.htmlControl1.Size = new System.Drawing.Size(261, 264);
            this.htmlControl1.TabIndex = 0;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMainForm";
            this.Text = "Web Form App";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Skybound.Gecko.GeckoWebBrowser ffMainBrowser;
        private Library.user.control.HtmlControl htmlControl1;


    }
}

