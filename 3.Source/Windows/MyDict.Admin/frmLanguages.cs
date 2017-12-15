﻿using System;
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
                List<Language> languages = (List<Language>)response.Data;
                foreach(Language lang in languages)
                {
                    MessageBox.Show(lang.Name);
                }
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
