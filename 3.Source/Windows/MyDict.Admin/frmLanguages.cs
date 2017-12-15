using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDict.Admin.Database;
using System.Net;
using MyDict.Admin.ServiceHelper;
using MyDict.Admin.Entity;
using System.Diagnostics;

namespace MyDict.Admin
{
    public partial class frmLanguages : Form
    {
        private System.Data.DataSet _ds = new DataSet();

        public frmLanguages()
        {
            InitializeComponent();
        }

        private void InitCriteria()
        {
            cbCriteria.Items.Clear();
            cbCriteria.Items.Add("< Select search criteria >");
            cbCriteria.SelectedIndex = 0;
            LanguageTable languageTable = LanguageTable.Instance;
            foreach (Field f in languageTable.Fields.Values)
            {
                cbCriteria.Items.Add(f.Name);
            }
        }

        private void InitList()
        {
            lvLanguages.Columns.Clear();
            lvLanguages.Items.Clear();

            lvLanguages.Columns.Add("id", 50);
            lvLanguages.Columns.Add("name", 250);
            lvLanguages.Columns.Add("title", 300);

            _ds.Reset();

            LanguageService languageService = LanguageService.Instance;
            languageService.RequestCompletedEvent -= new Service.RequestCompleted(onRequestCompleted);
            languageService.ResetRequestData();
            languageService.AddRequestData("fields","*");
            languageService.RequestCompletedEvent += new Service.RequestCompleted(onRequestCompleted);
            languageService.Get();
        }

        void onRequestCompleted(Response response)
        {
            try
            {
                ListViewItem item = null;
                foreach (Language lang in response.Data)
                {
                    item = lvLanguages.Items.Add(lang.ID.ToString());
                    if(null != item)
                    {
                        item.SubItems.Add(lang.Name);
                        item.SubItems.Add(lang.Title);
                    }
                }
                lblStatus.Text = string.Format("Total: {0} language(s)", lvLanguages.Items.Count);
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }

        }

        private void frmLanguages_Load(object sender, EventArgs e)
        {
            InitCriteria();
            InitList();
        }

        private void frmLanguages_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmLanguage f = new frmLanguage();
            f.Mode = frmLanguage.EditMode.NEW;
            f.ShowDialog();
            if (f.Changed)
            {
                InitList(); //Refresh list
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmLanguage f = new frmLanguage();
            f.Mode = frmLanguage.EditMode.EDIT;

            ListViewItem item = lvLanguages.SelectedItems[0];
            f.Entity = new Language() { ID = uint.Parse(item.Text), Name = item.SubItems[1].Text, Title = item.SubItems[2].Text };

            f.ShowDialog();
            if (f.Changed)
            {
                InitList(); //Refresh list
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lvLanguages_DoubleClick(object sender, EventArgs e)
        {
            if (lvLanguages.SelectedItems.Count > 0)
            {
                btnEdit_Click(sender, e);
            }
        }

        private void lvLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = (lvLanguages.SelectedItems.Count > 0);
            btnDelete.Enabled = (lvLanguages.SelectedItems.Count > 0);
        }
    }
}
