using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

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
            var request = (HttpWebRequest)WebRequest.Create("http://localhost/services/index.php?__svc__=user&__usr__=" + user + "&__pwd__=" + Crypto.ToSHA256(pwd)+"&__cri__=name&__val__="+user);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var httpResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponse>(responseString);
           
            return httpResponse.Status == 200;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Invalid username or password!", "Login",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Account account = Settings.Instance.Account;

            account.UserName = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.RememberLogin = chbRemember.Checked;
            DialogResult = DialogResult.OK;
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
