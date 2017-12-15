using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict.Admin.ServiceHelper
{
    public class LanguageService : Service
    {
        private static LanguageService _instance = null;

        public static LanguageService Instance
        {
            get
            {
                if(null == _instance)
                {
                    _instance = new LanguageService();
                }
                return _instance;
            }
        }
        private LanguageService() : base("language")
        {
            URL = "/language/index.php";
        }
    }
}
