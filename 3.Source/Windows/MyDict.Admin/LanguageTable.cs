using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict.Admin.Database
{
    class LanguageTable : Table
    {
        private static LanguageTable _instance = null;
        public static LanguageTable Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new LanguageTable();
                }
                return _instance;
            }
        }

        private LanguageTable() : base("tbl_language")
        {
            Field id = new Field("id",  DataType.BIGINT, "Mã ngôn ngữ", 20, true, true);
            AddField("id", id);
            Field name = new Field("name", DataType.VARCHAR, "Tên ngôn ngữ", 50, false, true);
            AddField("name", name);
            Field title = new Field("title", DataType.VARCHAR, "Tiêu đề", 50);
            AddField("title", title);
        }
    }
}
