using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using Library.models;

namespace Library.user.control
{
    public partial class HtmlControl : UserControl
    {
        public HtmlControl()
        {
            InitializeComponent();
        }

        public HtmlControl(HtmlControlEntity entity)
        {
            InitializeComponent();
            this.txtTitle.Text = entity.Title;
            ListViewItem[] lvItem = new ListViewItem[entity.Names.Count - 1];
            string[] entitiesArr = entity.Names.Select(p=>p.Name).ToArray();
            for (int i = 0; i < entitiesArr.Length; i++)
            {
                lvItem[i] = new ListViewItem(entitiesArr[i]);
            }
            this.lvComponent.Items.AddRange(lvItem);
        }
    }
}
