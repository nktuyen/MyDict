using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MyDict
{
    [Serializable]
    public class Setting : IDisposable
    {
        public string Name { get; set; }
        public Setting(string name = "")
        {
            this.Name = name;
        }
        public void Dispose()
        {
            
        }

        public bool Load(string path)
        {
            Setting st = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                StreamReader reader = new StreamReader(path);
                st = (Setting)serializer.Deserialize(reader);
                reader.Close();
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            if (null != st)
            {
                this.Copy(st);
            }
            return true;
        }

        protected virtual void Copy(Setting s)
        {
            this.Name = s.Name;
        }

        public bool Save(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                StreamWriter writer = new StreamWriter(path);
                serializer.Serialize(writer, this);
                writer.Close();
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }

            return true;
        }
    }

    [Serializable]
    public class Account : Setting
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public Account(): base("Account")
        {
            UserName = string.Empty;
            Password = string.Empty;
            RememberLogin = false;
        }

        protected override void Copy(Setting s)
        {
            base.Copy(s);
            Account a = (Account)s;
            if (null != a)
            {
                this.UserName = a.UserName;
                this.Password = a.Password;
                this.RememberLogin = a.RememberLogin;
            }
        }
    }

    [Serializable]
    public class Settings
    {
        private static Settings _instance = null;
        private Account _account = new Account();
        
        public static Settings Instance
        {
            get
            {
                if (null == _instance)
                {
                    _instance = new Settings();
                }
                return _instance;
            }
        }

        public string Location
        {
            get
            {
                string appDataFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appName = System.AppDomain.CurrentDomain.FriendlyName;
                string fullPath = appDataFolder + "\\" + appName + "\\";
                return fullPath;
            }
        }

        public string FileName
        {
            get { return "Settings.xml"; }
        }

        public Account Account
        {
            get { return _account; }
        }

        private Settings()
        {
            _account = new Account();
        }

        public bool Load()
        {
            Account.Load(Location + FileName);
            return true;
        }

        public bool Save()
        {
            Account.Save(Location + FileName);
            return true;
        }
    }
}
