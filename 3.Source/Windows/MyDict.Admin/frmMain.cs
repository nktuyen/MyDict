using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDict.Admin
{
    public partial class frmMain : Form
    {
        private Button btnLanguages;

        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnLanguages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanguages
            // 
            this.btnLanguages.Location = new System.Drawing.Point(12, 12);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(100, 40);
            this.btnLanguages.TabIndex = 0;
            this.btnLanguages.Text = "Languages";
            this.btnLanguages.UseVisualStyleBackColor = true;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.btnLanguages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dictionary Admin";
            this.ResumeLayout(false);

        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            frmLanguages f = new frmLanguages();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
