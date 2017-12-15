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
using MyDict.Admin.Entity;
using MyDict.Admin.ServiceHelper;

namespace MyDict.Admin
{
    public partial class frmLanguage : Form
    {
        public enum EditMode { NEW,EDIT}
        public Language Entity { get; set; }
        public EditMode  Mode { get; set; }
        public bool Changed
        {
            get
            {
                return true;
            }
        }
        public frmLanguage()
        {
            InitializeComponent();
            Mode = EditMode.NEW;
        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            if(Mode == EditMode.NEW)
            {
                Entity = new Language();
                txtID.Text = "";
            }
            else
            {
                txtID.Text = Entity.ID.ToString();
            }
            
            txtName.Text = Entity.Name;
            txtTitle.Text = Entity.Title;

            txtID.ReadOnly = true;
            txtName.ReadOnly = false;
            txtTitle.ReadOnly = false;
            btnSave.Enabled = false;
            btnReset.Enabled = true;
        }

        private bool SaveEntity()
        {
            LanguageService languageService = LanguageService.Instance;
            languageService.AddRequestData(lblID.Text, txtID.Text);
            languageService.AddRequestData(lblName.Text, txtName.Text);
            languageService.AddRequestData(lblTitle.Text, txtTitle.Text);

            //Temporarily lock edit controls
            txtName.ReadOnly = true;
            txtTitle.ReadOnly = true;

            if (Mode== EditMode.NEW)
            {
                languageService.Put();
            }
            else
            {
                languageService.Post();
            }

            //Un-lock edit controls
            txtName.ReadOnly = false;
            txtTitle.ReadOnly = false;
            return true;
        }

        private void frmLanguage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtName.Text != Entity.Name)||(txtTitle.Text!=Entity.Title);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (txtName.Text != Entity.Name) || (txtTitle.Text != Entity.Title);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveEntity())
            {
                this.Mode = EditMode.EDIT;
                btnSave.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = Entity.ID.ToString();
            txtName.Text = Entity.Name;
            txtTitle.Text = Entity.Title;
        }
    }
}
