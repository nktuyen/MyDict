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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbVocabularies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            if (null != assembly)
            {
                this.Text = assembly.GetName().Name + " " + assembly.GetName().Version.Major + "." + assembly.GetName().Version.Minor + "." + assembly.GetName().Version.Revision + "." + assembly.GetName().Version.Build;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void wrdViewer_OnEditClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }

        private void wrdViewer_OnLoveClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Love");
        }

        private void wrdViewer_OnPreferencesClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Preferences");
        }

        private void wrdViewer_OnPrintClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Print");
        }

        private void wrdViewer_OnRefreshClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh");
        }
    }
}
