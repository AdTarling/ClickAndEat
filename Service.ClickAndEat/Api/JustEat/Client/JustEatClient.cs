using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Service.ClickAndEat.Api.JustEat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Service.ClickAndEat.Api.JustEat.Client
{
    public class JustEatClient
    {
        private HttpClient client { get; set; }

        public JustEatClient()
        {
            client = new HttpClient();
        }

        public T Get<T>(string queryString) where T : new()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://api-interview.just-eat.com/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            client.DefaultRequestHeaders.Add("Authorization", "Basic VGVjaFRlc3RBUEk6dXNlcjI=");
            client.DefaultRequestHeaders.Add("Host", "api-interview.just-eat.com");

            HttpRequestMessage request = new HttpRequestMessage();
            HttpResponseMessage response = client.GetAsync(queryString).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
            else
            {
                return new T(); 
            }
        }

        private void SetStandardHeaders()
        {

        }
    }
}