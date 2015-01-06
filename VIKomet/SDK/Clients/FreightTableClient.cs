﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.VIFrete;
using VIKomet.Framework.Common;

namespace VIKomet.SDK.Clients
{
    public class FreightTableClient : BaseClient
    { 

        public FreightTableClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

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

        public PagedList<FreightTable> GetAllFreightTable()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/freight/freighttable").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<FreightTable>>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}