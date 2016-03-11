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
            this.grComponents = new System.Windows.Forms.GroupBox();
            this.htmlControl1 = new Library.user.control.HtmlControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grPreview = new System.Windows.Forms.GroupBox();
            this.splitPreviewer = new System.Windows.Forms.SplitContainer();
            this.txtHtmlUrl = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblHtmlUrl = new System.Windows.Forms.Label();
            this.ffMainBrowser = new Skybound.Gecko.GeckoWebBrowser();
            this.grComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPreviewer)).BeginInit();
            this.splitPreviewer.Panel1.SuspendLayout();
            this.splitPreviewer.Panel2.SuspendLayout();
            this.splitPreviewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grComponents
            // 
            this.grComponents.Controls.Add(this.htmlControl1);
            this.grComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grComponents.Location = new System.Drawing.Point(0, 0);
            this.grComponents.Name = "grComponents";
            this.grComponents.Size = new System.Drawing.Size(267, 715);
            this.grComponents.TabIndex = 0;
            this.grComponents.TabStop = false;
            this.grComponents.Text = "Components";
            // 
            // htmlControl1
            // 
            this.htmlControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlControl1.BackColor = System.Drawing.Color.DarkOrange;
            this.htmlControl1.Location = new System.Drawing.Point(2, 19);
            this.htmlControl1.Name = "htmlControl1";
            this.htmlControl1.Size = new System.Drawing.Size(261, 264);
            this.htmlControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grPreview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grComponents);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 715);
            this.splitContainer1.SplitterDistance = 970;
            this.splitContainer1.TabIndex = 0;
            // 
            // grPreview
            // 
            this.grPreview.Controls.Add(this.splitPreviewer);
            this.grPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPreview.Location = new System.Drawing.Point(0, 0);
            this.grPreview.Name = "grPreview";
            this.grPreview.Size = new System.Drawing.Size(970, 715);
            this.grPreview.TabIndex = 0;
            this.grPreview.TabStop = false;
            this.grPreview.Text = "HTML Previewer";
            // 
            // splitPreviewer
            // 
            this.splitPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPreviewer.Location = new System.Drawing.Point(3, 16);
            this.splitPreviewer.Name = "splitPreviewer";
            this.splitPreviewer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPreviewer.Panel1
            // 
            this.splitPreviewer.Panel1.Controls.Add(this.txtHtmlUrl);
            this.splitPreviewer.Panel1.Controls.Add(this.btnBrowser);
            this.splitPreviewer.Panel1.Controls.Add(this.lblHtmlUrl);
            // 
            // splitPreviewer.Panel2
            // 
            this.splitPreviewer.Panel2.Controls.Add(this.ffMainBrowser);
            this.splitPreviewer.Size = new System.Drawing.Size(964, 696);
            this.splitPreviewer.SplitterDistance = 39;
            this.splitPreviewer.TabIndex = 0;
            // 
            // txtHtmlUrl
            // 
            this.txtHtmlUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHtmlUrl.Location = new System.Drawing.Point(81, 10);
            this.txtHtmlUrl.Name = "txtHtmlUrl";
            this.txtHtmlUrl.Size = new System.Drawing.Size(806, 20);
            this.txtHtmlUrl.TabIndex = 7;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(893, 8);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(67, 23);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblHtmlUrl
            // 
            this.lblHtmlUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHtmlUrl.AutoSize = true;
            this.lblHtmlUrl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHtmlUrl.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHtmlUrl.Location = new System.Drawing.Point(17, 13);
            this.lblHtmlUrl.Name = "lblHtmlUrl";
            this.lblHtmlUrl.Size = new System.Drawing.Size(47, 13);
            this.lblHtmlUrl.TabIndex = 6;
            this.lblHtmlUrl.Text = "Html Url:";
            // 
            // ffMainBrowser
            // 
            this.ffMainBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ffMainBrowser.Location = new System.Drawing.Point(0, 0);
            this.ffMainBrowser.Name = "ffMainBrowser";
            this.ffMainBrowser.Size = new System.Drawing.Size(964, 653);
            this.ffMainBrowser.TabIndex = 7;
            this.ffMainBrowser.DomClick += new Skybound.Gecko.GeckoDomEventHandler(this.ffMainBrowser_DomClick);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 715);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMainForm";
            this.Text = "Web Form App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.grComponents.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grPreview.ResumeLayout(false);
            this.splitPreviewer.Panel1.ResumeLayout(false);
            this.splitPreviewer.Panel1.PerformLayout();
            this.splitPreviewer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPreviewer)).EndInit();
            this.splitPreviewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grComponents;
        private Library.user.control.HtmlControl htmlControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grPreview;
        private System.Windows.Forms.SplitContainer splitPreviewer;
        private System.Windows.Forms.TextBox txtHtmlUrl;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblHtmlUrl;
        private Skybound.Gecko.GeckoWebBrowser ffMainBrowser;



    }
}

