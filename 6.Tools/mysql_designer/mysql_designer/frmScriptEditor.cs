using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace mysql_designer
{
    public partial class frmScriptEditor : Form
    {
        private string _script = string.Empty;
        public List<string> Tables { get; private set; }
        private string Server { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private bool ShowPassword { get; set; }
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
            Tables = new List<string>();
            Server = "127.0.0.1";
            User = "root";
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
            if(this.Tables.Count==1)
            {
                dlg.FileName = Tables[0];
            }
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

        private void OnScriptCompleted(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            btnSave.Enabled = true;
            txtScript.Enabled = true;

            MessageBox.Show(Constants.GetResourceString(Constants.MSG_SCRIPT_EXECUTE_SUCCESS), Constants.GetResourceString(Constants.STR_INFORMATION), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnStatementExecuted(object sender, MySqlScriptEventArgs e)
        {
            Debug.Print(Environment.NewLine + e.StatementText);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            frmServerInfo frm = new frmServerInfo();

            frm.Server = this.Server;
            frm.Username = this.User;
            frm.Password = this.Password;
            frm.ShowPassword = this.ShowPassword;

            if(frm.ShowDialog()!= DialogResult.OK)
            {
                return;
            }

            this.Server = frm.Server;
            this.User = frm.Username;
            this.Password = frm.Password;
            this.ShowPassword = frm.ShowPassword;

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            string connString = "Server=" + frm.Server + ";uid=" + frm.Username+ ";pwd=" + frm.Password+ ";port=3306;database="+frm.Database;
            
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, Constants.GetResourceString(Constants.STR_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySql.Data.MySqlClient.MySqlScript script = new MySqlScript(conn, txtScript.Text);
            btnExecute.Enabled = false;
            btnSave.Enabled = false;
            txtScript.Enabled = false;

            try
            {
                script.StatementExecuted += new MySqlStatementExecutedEventHandler(OnStatementExecuted);
                script.ScriptCompleted += new EventHandler(OnScriptCompleted);
                script.Execute();
            }
            catch(MySqlException ex)
            {
                conn.Close();
                
                btnExecute.Enabled = true;
                btnSave.Enabled = true;
                txtScript.Enabled = true;
                
                MessageBox.Show(ex.Message, Constants.GetResourceString(Constants.STR_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
