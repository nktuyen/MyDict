using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_designer
{
    public class Constants
    {
        public static string MSG_TABLE_NAME_CELL_INDEX_CANNOT_BE_EMPTY = "MSG_TABLE_NAME_CELL_INDEX_CANNOT_BE_EMPTY";
        public static string STR_INFORMATION = "STR_INFORMATION";
        public static string STR_WARNING = "STR_WARNING";
        public static string STR_ERROR = "STR_ERROR";
        public static string STR_SAVE = "STR_SAVE";
        public static string STR_APPNAME = "STR_APPNAME";
        public static string STR_FILESAVEFILTERS = "STR_FILESAVEFILTERS";
        public static string MSG_NO_SHEET_SPECIFIED = "MSG_NO_SHEET_SPECIFIED";
        public static string MSG_SHEET_CANNOT_FOUND = "MSG_SHEET_CANNOT_FOUND";
        public static string MSG_SCRIPT_IS_SAVED_SUCCESS = "MSG_SCRIPT_IS_SAVED_SUCCESS";
        public static string MSG_INVALID_ADDRESS = "MSG_INVALID_ADDRESS";
        public static string MSG_SCRIPT_EXECUTE_SUCCESS = "MSG_SCRIPT_EXECUTE_SUCCESS";

        public static string GetResourceString(string key)
        {
            return Properties.Resources.ResourceManager.GetString(key);
        }
    }
}
