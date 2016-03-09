using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Skybound.Gecko.Xpcom.Initialize(@"C:\xulrunner");
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            ffMainBrowser.Navigate(@"D:\Copy\_WEBSITE Template\TEMPLATE WEBSITE\BBShop- Buon Ban Lon Ga\index.html");
        }

        private void ffMainBrowser_DomClick(object sender, Skybound.Gecko.GeckoDomEventArgs e)
        {
            frmAddHtmlControl frm = new frmAddHtmlControl();
            frm.ShowDialog();
        }
    }
}
