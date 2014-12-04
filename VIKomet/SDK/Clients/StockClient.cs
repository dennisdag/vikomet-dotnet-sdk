 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.Settings;
using VIKomet.SDK.Entities.Stock; 

namespace VIKomet.SDK.Clients
{
    public class StockClient : BaseClient
    {
 
        public StockClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public SalesChannel GetSalesChannelByID(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/saleschannel/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<SalesChannel>().Result;
                return r;
            }
            else
           {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Stock GetStockByID(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/inventory/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Stock>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Stock GetByInternalSkuId(string internalSkuId)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/inventory/internalSkuId/" + internalSkuId).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Stock>().Result;
                return r;
            }
            else
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public List<Stock> GetStocksInAlert()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/inventory/alert").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<Stock>>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public long CountStocks()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/inventory/quantity").Result;  // Blocking call!
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

        public long CountSalesChannel()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/stock/saleschannel/quantity").Result;  // Blocking call!
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
