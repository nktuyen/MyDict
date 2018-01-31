using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_designer
{
    public partial class frmServerInfo : Form
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public  string Database { get; set; }
        public bool ShowPassword { get; set; }

        public frmServerInfo()
        {
            InitializeComponent();

            Server = "127.0.0.1";
            Username = "root";
        }

        private void frmServerInfo_Load(object sender, EventArgs e)
        {
            txtServeraddress.Text = this.Server;
            txtUsername.Text = this.Username;
            txtPassword.Text = this.Password;
            chbShowpassword.Checked = this.ShowPassword;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IPAddress server;
            if(!IPAddress.TryParse(txtServeraddress.Text, out server))
            {
                MessageBox.Show(Constants.GetResourceString(Constants.MSG_INVALID_ADDRESS), Constants.GetResourceString(Constants.STR_ERROR), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServeraddress.Focus();
                return;
            }

            Server = txtServeraddress.Text;
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            Database = cbDatabases.Text;
            ShowPassword = chbShowpassword.Checked;

            DialogResult = DialogResult.OK;
        }

        private void chbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowpassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';

        }

        private void txtServeraddress_TextChanged(object sender, EventArgs e)
        {
            btnObtain.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0));
            btnOK.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0) & (cbDatabases.Text.Length > 0));

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnObtain.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0));
            btnOK.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0) & (cbDatabases.Text.Length > 0));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnObtain.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0));
            btnOK.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0) & (cbDatabases.Text.Length > 0));
        }

        private void btnObtain_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            string connString = "Server=" + txtServeraddress.Text + ";uid=" + txtUsername.Text + ";pwd=" + txtPassword.Text + ";port=3306;database=information_schema";
            
            btnObtain.Enabled = false;
            cbDatabases.Items.Clear();

            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SCHEMA_NAME FROM SCHEMATA";
                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                string dbName = string.Empty;
                while (reader.Read())
                {
                    dbName = (string)reader[0];
                    if (dbName.Length > 0)
                    {
                        cbDatabases.Items.Add(dbName);
                    }
                }

                if(cbDatabases.Items.Count > 0)
                {
                    cbDatabases.DroppedDown = true;
                }

                reader.Close();
                conn.Close();
                
                btnObtain.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0));
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                btnObtain.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0));
                return;
            }

        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0) & (cbDatabases.Text.Length > 0));
        }

        private void cbDatabases_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = ((txtServeraddress.TextLength > 0) && (txtUsername.TextLength > 0) && (txtPassword.TextLength > 0) & (cbDatabases.Text.Length > 0));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
