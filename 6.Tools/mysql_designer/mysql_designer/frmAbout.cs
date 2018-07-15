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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly asy = System.Reflection.Assembly.GetExecutingAssembly();
            if (asy != null)
            {
                System.Reflection.AssemblyName asyName = asy.GetName();
                if(asyName!=null)
                {
                    string ver = string.Format("{0} {1}.{2}.{3}", asyName.Name, asyName.Version.Major, asyName.Version.Minor, asyName.Version.Revision);
                    this.Text = ver;
                }
            }
        }
    }
}
