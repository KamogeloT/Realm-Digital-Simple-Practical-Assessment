using System;
using Realm_Digital_Simple_Practical;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Realm_Digital_Simple_Practical
{
   public class GetEmployees
    {
        public static  List<EmployeeModel> LoadEmployees()
        {
            string jsonString;
          

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(ApiCaller.ApiClient.BaseAddress);
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

         
           
            using (Stream stream = WebResp.GetResponseStream()) 
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            List<EmployeeModel> items = JsonConvert.DeserializeObject<List<EmployeeModel>>(jsonString);
           
            return items;

        }

    }
}
