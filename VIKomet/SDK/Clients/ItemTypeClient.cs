using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Clients
{
    public class ItemTypeClient : BaseClient
    {
        

        public ItemTypeClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public int Count()
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/datastorage/itemtemplate/count/quantity")).Result;  // Blocking call!
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
