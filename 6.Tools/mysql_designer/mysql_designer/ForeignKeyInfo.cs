using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_designer
{
    public class ForeignKeyInfo
    {
        public string FieldName { get; private set; }
        public string ForeignTable { get; set; }
        public string ForeignFieldName { get; set; }
        public ForeignKeyInfo(string fieldName, string foreignTable="", string sourceField="")
        {
            FieldName = fieldName;
            ForeignTable = foreignTable;
            ForeignFieldName = sourceField;
        }
    }
}
