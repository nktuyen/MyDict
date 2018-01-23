using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Drawing;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new MySQLRibbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace mysql_designer
{
    internal class PictureConverter : AxHost
    {
        private PictureConverter() : base(String.Empty) { }

        static public stdole.IPictureDisp ImageToPictureDisp(Image image)
        {
            return (stdole.IPictureDisp)GetIPictureDispFromPicture(image);
        }

        static public stdole.IPictureDisp IconToPictureDisp(Icon icon)
        {
            return ImageToPictureDisp(icon.ToBitmap());
        }

        static public Image PictureDispToImage(stdole.IPictureDisp picture)
        {
            return GetPictureFromIPicture(picture);
        }
    }


    [ComVisible(true)]
    public class MySQLRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public MySQLRibbon()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("mysql_designer.MySQLRibbon.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226
        public stdole.IPictureDisp Ribbon_GetImage(string imageName)
        {
            return PictureConverter.IconToPictureDisp((Icon)Properties.Resources.ResourceManager.GetObject(imageName));
        }

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public bool Ribbon_GetEnabled(Office.IRibbonControl control)
        {
            return true;
        }

        public bool Ribbon_GetVisible(Office.IRibbonControl control)
        {
            return true;
        }

        public string Ribbon_GetLabel(Office.IRibbonControl control)
        {
            string res = Properties.Resources.ResourceManager.GetString(control.Id + "_Label");

            return res;
        }

        public void Ribbon_OnAction(Office.IRibbonControl control)
        {
            if(null != control)
            {
                if(string.Compare(control.Id, "MySQL_Designer_btnGenerate") == 0)
                {
                    frmGenerator frm = new frmGenerator();
					frm.Book = ExcelHelper.Instance.Application.ActiveWorkbook;
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
