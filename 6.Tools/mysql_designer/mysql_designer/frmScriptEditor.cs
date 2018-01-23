using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_designer
{
    public partial class frmScriptEditor : Form
    {
        private string _script = string.Empty;
        public string Script
        {
            get { return _script; }
            set
            {
                _script = value;
                txtScript.Text = _script;
            }
        }
        public frmScriptEditor()
        {
            InitializeComponent();
        }

        private void chbWordwrap_CheckedChanged(object sender, EventArgs e)
        {
            txtScript.WordWrap = chbWordwrap.Checked;
        }

        private void frmScriptEditor_Load(object sender, EventArgs e)
        {

        }

        private void frmScriptEditor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtScript_TextChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = (bool)(txtScript.TextLength > 0);
            btnSave.Enabled = (bool)(txtScript.TextLength > 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = Constants.GetResourceString(Constants.STR_SAVE);
            dlg.Filter = Constants.GetResourceString(Constants.STR_FILESAVEFILTERS);
            dlg.OverwritePrompt = true;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = null;
                try
                {
                    writer = new System.IO.StreamWriter(dlg.FileName, false, new UTF8Encoding(false));
                    writer.AutoFlush = true;
                    foreach(string line in txtScript.Lines)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                    MessageBox.Show(Constants.GetResourceString(Constants.MSG_SCRIPT_IS_SAVED_SUCCESS), Constants.GetResourceString(Constants.STR_INFORMATION), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Constants.GetResourceString(Constants.STR_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }
    }
}
