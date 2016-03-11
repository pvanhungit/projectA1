using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Render_Web_Application
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            string xulrunner = Constant
                .CURREN_DIRECTORY.Replace(@"Render_Web_Application\bin\Debug", @"Library\libs\xulrunner");
            Skybound.Gecko.Xpcom.Initialize(xulrunner);
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
        }

        private void ffMainBrowser_DomClick(object sender, Skybound.Gecko.GeckoDomEventArgs e)
        {
            frmAddHtmlControl frm = new frmAddHtmlControl();
            frm.ShowDialog();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                txtHtmlUrl.Text = openFile.FileName;
                ffMainBrowser.Navigate(txtHtmlUrl.Text);
            }
        }
    }
}
