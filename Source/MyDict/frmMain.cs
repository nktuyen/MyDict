using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace MyDict
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Settings.Instance.Load();
            cbFilter.Items.Add("(No Filter");
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings settings = Settings.Instance;
            string url = "http://localhost/services/index.php?__svc__=user&__usr__=" + settings.Account.UserName+"&__pwd__="+ Crypto.ToSHA256(settings.Account.Password)+"&__cri__=id&__val__=all";
            Debug.Print(url);
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var httpResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponse>(responseString);
            if(httpResponse.Status == 200)
            {
                try
                {
                    tbl_user[]    arr = Newtonsoft.Json.JsonConvert.DeserializeObject<tbl_user[]>(httpResponse.Data.ToString(), s);
                    foreach(var obj in arr)
                    {
                        tbl_user user = (tbl_user)obj;
                    }
                }
                catch(Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbVocabularies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Instance.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            if(f.ShowDialog()!= DialogResult.OK)
            {
                this.Close();
                return;
            }

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
            wrdEditor.Mode = EditorModes.Edit;
            wrdEditor.Show();
            wrdViewer.Hide();
        }

        private void wrdViewer_OnLoveClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Love");
        }

        private void wrdViewer_OnPreferencesClicked(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void wrdViewer_OnPrintClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Print");
        }

        private void wrdViewer_OnRefreshClicked(object sender, EventArgs e)
        {
           
        }

        private void wrdViewer_OnAddNew(object sender, EventArgs e)
        {
            wrdEditor.Mode = EditorModes.AddNew;
            wrdEditor.Show();
            wrdViewer.Hide();
        }

        private void wrdEditor_OnClose(object sender, EventArgs e)
        {
            wrdEditor.Hide();
            wrdViewer.Show();
        }

        private void wrdEditor_OnEdit(object sender, EventArgs e)
        {
            wrdViewer.Hide();
            wrdEditor.Mode = EditorModes.Edit;
            wrdEditor.Show();
        }

        private void wrdEditor_OnNew(object sender, EventArgs e)
        {
            wrdViewer.Hide();
            wrdEditor.Mode = EditorModes.AddNew;
            wrdEditor.Show();
        }

        private void wrdEditor_OnSave(object sender, EventArgs e)
        {
            wrdEditor.Mode = EditorModes.None;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(wrdEditor.Visible)
            {
                wrdEditor_OnClose(this, new EventArgs());
            }
        }

        private void wrdViewer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
