using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Realm_Digital_Simple_Practical
{
  public static class ApiCaller
    {
        public static HttpClient ApiClient { get; set; }
        public static void intializeApi()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://eohmc-acme-api.azurewebsites.net/swagger/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicatio/json"));
        }
    }
}
