using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace mysql_designer
{
    public class ExcelHelper
    {
        private static ExcelHelper _instance = null;

        public static ExcelHelper Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new ExcelHelper();
                }
                return _instance;
            }
        }

        public Excel.Application Application { get; set; }

        private ExcelHelper()
        {

        }


    }
}
