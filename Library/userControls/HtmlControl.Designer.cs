namespace Library.user.control
{
    partial class HtmlControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvComponent = new System.Windows.Forms.ListView();
            this.txtTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvComponent
            // 
            this.lvComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvComponent.Location = new System.Drawing.Point(0, 17);
            this.lvComponent.MultiSelect = false;
            this.lvComponent.Name = "lvComponent";
            this.lvComponent.Size = new System.Drawing.Size(268, 247);
            this.lvComponent.TabIndex = 3;
            this.lvComponent.UseCompatibleStateImageBehavior = false;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(35, 17);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title";
            // 
            // HtmlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.lvComponent);
            this.Controls.Add(this.txtTitle);
            this.Name = "HtmlControl";
            this.Size = new System.Drawing.Size(268, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvComponent;
        private System.Windows.Forms.Label txtTitle;
    }
}
