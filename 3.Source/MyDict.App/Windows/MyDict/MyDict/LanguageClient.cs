using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class LanguageClient : Client
    {
        private const string LANGUAGE_SERVICE_URI = "http://localhost/mydict/services/language/";
        private static LanguageClient instance = null;
        private LanguageClient()
            :base(LANGUAGE_SERVICE_URI)
        {

        }

        public static LanguageClient Instance
        {
            get
            {
                if (null == instance)
                    instance = new LanguageClient();
                return instance;
            }
        }
    }
}
