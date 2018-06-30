using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class Client
    {
        private const string userName = "nktuyen@hotmail.com";
        private const string passWord = "cefb242b79b8a158723eaeb6cbfeeb9844a0c07c";
        private string requestUri = string.Empty;
        private static HttpClient httpClient = new HttpClient();
        private Dictionary<string, string> parameters = new Dictionary<string, string>();
        private DataSet data = null;

        public Dictionary<string,string> Parameters
        {
            get { return this.parameters; }
        }

        protected Client(string serviceUri)
        {
            this.requestUri = serviceUri;
            parameters.Add("__u__", Client.userName);
            parameters.Add("__p__", Client.passWord);
        }

        private string BuildGetParams()
        {
            string result = string.Empty;
            if (this.Parameters.Count > 0)
            {
                int nIndex = 0;
                foreach(KeyValuePair<string,string> param in this.Parameters)
                {
                    if (0 < nIndex)
                        result += "&";
                    result += (param.Key + "=" + param.Value);
                    nIndex++;
                }
            }
            return result;
        }

        public async Task<HttpResponse> Get(string query = null)
        {
            var uri = string.Empty;
            if (null != query)
            {
                uri = Uri.EscapeUriString(this.requestUri + "?" + query);
            }
            else
            {
                uri = Uri.EscapeUriString(this.requestUri + "?" + BuildGetParams());
            }
            Task<string> getResult = Client.httpClient.GetStringAsync(uri);
            string json = await getResult;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponse>(json);
        }

        public async Task<HttpResponse> Post(string query = null)
        {
            var uri = Uri.EscapeUriString(this.requestUri);
            var content = string.Empty;
            if (null != query)
            {
                content = Uri.EscapeDataString(query);
            }
            else
            {
                content = Uri.EscapeDataString(BuildGetParams());
            }
            Task<HttpResponseMessage> getResult = Client.httpClient.PostAsync(uri, new StringContent(content));
            HttpResponseMessage response = await getResult;
            Task<string> readResponse = response.Content.ReadAsStringAsync();
            string json = await readResponse;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponse>(json);
        }
    }
}
