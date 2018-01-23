using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_designer
{
    public class LogInfo
    {
        public enum LogType{ NONE=0, INFO, WARNING, ERROR};
        public LogType Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public LogInfo(LogType type, string msg, string title="")
        {
            this.Type = type;
            this.Message = msg;
            this.Title = title;
        }
    }
    public class Logger
    {
        private static Logger _instance = null;
        private List<LogInfo> _logs = null;

        public static Logger Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public List<LogInfo> Logs { get; }

        private Logger()
        {
            _logs = new List<LogInfo>();
        }

        public void Reset()
        {
            _logs.Clear();
        }

        public void Write(LogInfo.LogType type, string message, string title="")
        {
            _logs.Add(new LogInfo(type, message, title));
        }
    }
}
