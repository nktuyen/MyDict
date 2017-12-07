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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private bool Login(string user, string pwd)
        {
            
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!Login(txtUsername.Text, txtPassword.Text))
            {
                return;
            }

            Account account = Settings.Instance.Account;

            account.UserName = txtUsername.Text;
            account.Password = Crypto.ToSHA256(txtPassword.Text);
            account.RememberLogin = chbRemember.Checked;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (txtUsername.Text.Length > 0) && (txtPassword.Text.Length > 0);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (txtUsername.Text.Length > 0) && (txtPassword.Text.Length > 0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Account account = Settings.Instance.Account;
            txtUsername.Text = account.UserName;
            txtPassword.Text = account.Password;
            chbRemember.Checked = account.RememberLogin;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
