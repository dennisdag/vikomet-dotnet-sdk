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

        public long CountFreightTables()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/freight/freighttable/quantity").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<long>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
