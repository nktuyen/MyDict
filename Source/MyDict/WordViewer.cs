using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDict
{
    public partial class WordViewer : UserControl
    {
        public event EventHandler OnRefresh;
        public event EventHandler OnLove;
        public event EventHandler OnPrinting;
        public event EventHandler OnEdit;
        public event EventHandler OnPreferences;
        public event EventHandler OnAddNew;

        public WordViewer()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (null != OnRefresh)
            {
                this.OnRefresh(sender, e);
            }
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            if(null != OnLove)
            {
                this.OnLove(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (null != OnPrinting)
            {
                this.OnPrinting(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (null != OnEdit)
            {
                this.OnEdit(sender, e);
            }
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            if (null != OnPreferences)
            {
                this.OnPreferences(sender, e);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (null != OnAddNew)
            {
                this.OnAddNew(sender, e);
            }
        }

        private void WordViewer_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
