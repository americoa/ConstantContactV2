using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Aarvani.ConstantContactV2.Models;
using Newtonsoft.Json;

namespace Aarvani.ConstantContactV2.Requests
{
    public class RequestGet<T> : Base
    {
        public async  Task<ResultSet<T>> GetAll(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage result = new HttpResponseMessage();
                
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
              
                var _url = string.Format("{0}{1}&api_key={2}", ApiUrl, url,APIKey);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ BearToken);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                result = await client.GetAsync(_url);

                if (result.IsSuccessStatusCode)
                {
                    string jsonResult = result.Content.ReadAsStringAsync().Result;
                    var list = JsonConvert.DeserializeObject<ResultSet<T>>(jsonResult);
                    return list;
                }
                else
                {
                    string msg = result.Content.ReadAsStringAsync().Result;
                    throw new Exception(msg);
                }
            }
        }
    }
}
