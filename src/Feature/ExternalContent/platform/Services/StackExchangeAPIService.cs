using Mvp.Feature.ExternalContent.Models;
using Newtonsoft.Json;
using Sitecore.Diagnostics;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mvp.Feature.ExternalContent.Services
{
    public  class StackExchangeAPIService: IStackExchangeAPIService
    {
        private static readonly HttpClient client;
        static StackExchangeAPIService()
        {
             client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.stackexchange.com")
            };

        }

        public StackExchangeUsersModel GetstackExchangeUsers()
        {
            try
            {            
            var url = "https://api.stackexchange.com/2.3/users?order=desc&sort=reputation&site=sitecore";//string.Format("/api/v2/PublicHolidays/{0}/{1}", year, countryCode);
            HttpWebRequest ApiRequest = (HttpWebRequest)WebRequest.Create(url);
            ApiRequest.Method = "Get";
            WebResponse response = (HttpWebResponse)ApiRequest.GetResponse();
         
                using (response)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        string stream = reader.ReadToEnd();
                        var data = JsonConvert.DeserializeObject<StackExchangeUsersModel>(stream);
                        return data;
                    }
                }
        }
             catch (Exception ex)
            {
                Log.Error("Error in getting stack exchange users ", ex, this);
            }
            return null;
        }

    }
}
