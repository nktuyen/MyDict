using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDict
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private bool Apply()
        {
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Apply())
            {
                this.Close();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (this.Apply())
            {
                btnApply.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radSyncManual_CheckedChanged(object sender, EventArgs e)
        {
            cbSyncAutomaticType.Visible = (radSyncAutomatic.Checked);
            nmudSyncAutomaticMinutes.Visible = ((cbSyncAutomaticType.Visible) && (cbSyncAutomaticType.SelectedIndex == 2));
            cbSyncAutomaticTimeUnit.Visible = nmudSyncAutomaticMinutes.Visible;
        }

        private void radSyncAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            cbSyncAutomaticType.Visible = (radSyncAutomatic.Checked);
            nmudSyncAutomaticMinutes.Visible = ((cbSyncAutomaticType.Visible) && (cbSyncAutomaticType.SelectedIndex==2) );
            cbSyncAutomaticTimeUnit.Visible = nmudSyncAutomaticMinutes.Visible;
        }

        private void cbSyncAutomaticType_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmudSyncAutomaticMinutes.Visible = ((cbSyncAutomaticType.Visible) && (cbSyncAutomaticType.SelectedIndex == 2));
            cbSyncAutomaticTimeUnit.Visible = nmudSyncAutomaticMinutes.Visible;
        }
    }
}
