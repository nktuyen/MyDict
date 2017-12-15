using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using System.Web.Script.Serialization;
using MyDict.Admin.Entity;

namespace MyDict.Admin.ServiceHelper
{
    public class Response
    {
        public int Status { get; set; }
        public List<Language>  Data { get; set; }

        public Response()
        {
            Status = 0;
            Data = null;
        }
    }

    public class Service
    {
        public delegate void RequestCompleted(Response response);
        public event RequestCompleted RequestCompletedEvent;

        private string _responseString = string.Empty;
        public string Name { get; protected set; }
        public string URI { get; protected set; }
        public string User { get; private set; }
        public string Password { get; private set; }
        public string Token { get; private set; }
        public Dictionary<string, string> RequestData { get; private set; }
        protected HttpClient HttpClient { get; private set; }
        public Response Response { get; private set; }
        public Service(string name = "", string uri = "")
        {
            Name = name;
            URI = uri;
            User = "nktuyen@hotmail.com";
            Password = "de3bcbc68f9c92b925cb768c897f68b26b8404fad2db41ef6d5384b95d52accd";
            Token = "744966cb3d257c025cb3c64d92c1386586eeb70b93673dbec9f6a9a751295841";
            RequestData = new Dictionary<string, string>();
            HttpClient = new HttpClient();
#if true
            HttpClient.BaseAddress = new Uri("https://localhost/MyDict/services");
#else
            HttpClient.BaseAddress = new Uri("https://nktdict.000webhostapp.com/services");
#endif
            RequestData.Add("User", User);
            RequestData.Add("Password", Password);
            RequestData.Add("Token", Token);
            Response = new Response();
        }

        private void ParseResponse()
        {
            Response.Status = (int)HttpStatusCode.InternalServerError;
            Response.Data = null;

            if (_responseString != null)
            {

                try
                {
                    var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(_responseString);

                    if (null != response)
                    {
                        Response.Status = response.Status;
                        Response.Data = response.Data;
                    }

                    RequestCompletedEvent?.Invoke(Response);
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
        }

        public string AddRequestData(string key, string value)
        {
            try
            {
                if (!RequestData.ContainsKey(key))
                {
                    RequestData.Add(key, value);
                }
                return RequestData[key];
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return string.Empty;
            }
        }

        public void ResetRequestData()
        {
            RequestData.Clear();
            RequestData.Add("User", User);
            RequestData.Add("Password", Password);
            RequestData.Add("Token", Token);
        }

        public async void Post()
        {
            try
            {
                var content = new FormUrlEncodedContent(RequestData);
                var response = await HttpClient.PostAsync(HttpClient.BaseAddress+URI, content);
                _responseString = await response.Content.ReadAsStringAsync();
                ParseResponse();
            }
            catch(Exception ex) {
                Debug.Print(ex.Message);
            }

        }

        public async void Put()
        {
            try
            {
                var tempData = RequestData;
                tempData.Add("method", "PUT");
                var content = new FormUrlEncodedContent(tempData);
                var response = await HttpClient.PostAsync(HttpClient.BaseAddress + URI, content);
                _responseString = await response.Content.ReadAsStringAsync();
                ParseResponse();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public async void Delete()
        {
            try
            {
                var tempData = RequestData;
                tempData.Add("method", "DELETE");
                var content = new FormUrlEncodedContent(tempData);
                var response = await HttpClient.PostAsync(HttpClient.BaseAddress + URI, content);
                _responseString = await response.Content.ReadAsStringAsync();
                ParseResponse();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public async void Get()
        {
            try
            {
                string requestString = HttpClient.BaseAddress + URI + "?";
                uint count = 0;
                foreach(KeyValuePair<string,string> kv in RequestData)
                {
                    requestString += kv.Key + "=" + kv.Value;
                    count++;
                    if(count < RequestData.Count)
                    {
                        requestString += "&";
                    }
                }
                _responseString = await HttpClient.GetStringAsync(requestString);
                ParseResponse();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
