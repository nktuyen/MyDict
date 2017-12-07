using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace nktuyen.mydict
{
    class CountryService : ICountryService
    {
        string DBHost { get; set; }
        string DBName { get; set; }
        string DBUser { get; set; }
        string DBPwd { get; set; }
        string DBTable { get; set; }
        string ConnectionString { get; set; }
        DataSet Cache { get; set; }

        public CountryService()
        {
            DBHost = System.Configuration.ConfigurationManager.AppSettings.Get("DBHost");
            DBName = System.Configuration.ConfigurationManager.AppSettings.Get("DBName");
            DBUser = System.Configuration.ConfigurationManager.AppSettings.Get("DBUser");
            DBPwd = System.Configuration.ConfigurationManager.AppSettings.Get("DBPwd");
            DBTable = "tbl_country";
            ConnectionString = "Data Source=" + DBHost + ";Initial Catalog=" + DBName + ";Integrated Security=False;User Id=" + DBUser + ";Password=" + DBPwd + ";MultipleActiveResultSets=True;";
            Cache = new DataSet();
        }
        public CountryServiceResponse GetCountryByCode(string code)
        {
            List<Country> countries = new List<Country>();
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM " + DBTable;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                Cache.Reset();
                adapter.Fill(Cache);
                DataTable tbl_country = Cache.Tables[0];
                if (null != tbl_country)
                {
                    foreach (DataRow row in tbl_country.Rows)
                    {
                        countries.Add(new Country() { id = int.Parse(row["id"].ToString()), code = row["code"].ToString(), iso_code = row["iso"].ToString(), name = row["name"].ToString(), title = row["title"].ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CountryServiceResponse GetCountryByID(int id)
        {
            throw new NotImplementedException();
        }

        public CountryServiceResponse GetCountryByName(string name)
        {
            throw new NotImplementedException();
        }

        public CountryServiceResponse GetAllCountries()
        {
            throw new NotImplementedException();
        }
    }
}