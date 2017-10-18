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
        public event EventHandler OnRefreshClicked;
        public event EventHandler OnLoveClicked;
        public event EventHandler OnPrintClicked;
        public event EventHandler OnEditClicked;
        public event EventHandler OnPreferencesClicked;

        public WordViewer()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (null != OnRefreshClicked)
            {
                this.OnRefreshClicked(sender, e);
            }
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            if(null != OnLoveClicked)
            {
                this.OnLoveClicked(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (null != OnPrintClicked)
            {
                this.OnPrintClicked(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (null != OnEditClicked)
            {
                this.OnEditClicked(sender, e);
            }
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            if (null != OnPreferencesClicked)
            {
                this.OnPreferencesClicked(sender, e);
            }
        }
    }
}
