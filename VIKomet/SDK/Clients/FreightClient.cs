using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.Catalog;
using VIKomet.SDK.Entities.VIFrete;

namespace VIKomet.SDK.Clients
{
    public class FreightClient : BaseClient
    { 

        public FreightClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public List<FreightValue> GetCalculateFreight(decimal lenght, decimal width, decimal height, decimal weight, decimal price, long postalCode)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/freight/calculate/{0}/{1}/{2}/{3}/{4}/{5}", lenght, width, height, weight, price, postalCode)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<FreightValue>>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public List<FreightValue> PostCalculateFreight(FreightRequest request)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/webstore/freight/calculate/", request).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<FreightValue>>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public int CountFreightTables()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/freight/freighttable/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<int>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
