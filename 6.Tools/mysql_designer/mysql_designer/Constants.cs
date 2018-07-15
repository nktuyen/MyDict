using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_designer
{
    public class Constants
    {
        public static string MySQL_Designer_btnAbout_Label = "MySQL_Designer_btnAbout_Label";
        public static string MySQL_Designer_btnGenerate = "MySQL_Designer_btnGenerate";
        public static string MySQL_Designer_btnGenerate_Label = "MySQL_Designer_btnGenerate_Label";
        public static string MySQL_Designer_Menu_Label = "MySQL_Designer_Menu_Label";

        public static string MSG_TABLE_NAME_CELL_INDEX_CANNOT_BE_EMPTY = "MSG_TABLE_NAME_CELL_INDEX_CANNOT_BE_EMPTY";
        public static string STR_INFORMATION = "STR_INFORMATION";
        public static string STR_WARNING = "STR_WARNING";
        public static string STR_ERROR = "STR_ERROR";
        public static string STR_SAVE = "STR_SAVE";
        public static string STR_OPEN = "STR_OPEN";
        public static string STR_APPNAME = "STR_APPNAME";
        public static string STR_EXECUTE = "STR_EXECUTE";
        public static string STR_FILESAVEFILTERS = "STR_FILESAVEFILTERS";
        public static string MSG_NO_SHEET_SPECIFIED = "MSG_NO_SHEET_SPECIFIED";
        public static string MSG_SHEET_CANNOT_FOUND = "MSG_SHEET_CANNOT_FOUND";
        public static string MSG_SCRIPT_IS_SAVED_SUCCESS = "MSG_SCRIPT_IS_SAVED_SUCCESS";
        public static string MSG_INVALID_ADDRESS = "MSG_INVALID_ADDRESS";
        public static string MSG_SCRIPT_EXECUTE_SUCCESS = "MSG_SCRIPT_EXECUTE_SUCCESS";
        public static string MSG_PLEASE_CHOOSE_A_MACRO_TO_INSERT = "MSG_PLEASE_CHOOSE_A_MACRO_TO_INSERT";

        public static string MYSQL_VARCHAR = "VARCHAR";
        public static string MYSQL_TEXT = "TEXT";
        public static string MYSQL_DATE = "DATE";
        public static string MYSQL_DATETIME = "DATETIME";
        public static string MYSQL_TIME = "TIME";

        public static string GetResourceString(string key)
        {
            return Properties.Resources.ResourceManager.GetString(key);
        }
    }
}
