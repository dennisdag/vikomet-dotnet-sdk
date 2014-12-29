

using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using VIKomet.SDK.Entities.Catalog;
using VIKomet.SDK.Entities.Datastorage;
using VIKomet.SDK.Entities.Messaging;
using VIKomet.SDK.Entities.Messaging.Log;
using VIKomet.SDK.Entities.Messaging.Messages;
using VIKomet.Framework.Common;

namespace VIKomet.SDK.Clients
{
    public class SubscriptionClient : BaseClient
    {


        public SubscriptionClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public Subscription GetSubscriptionById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/messaging/messages/subscription/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Subscription>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

       

        //public int Count()
        //{
        //    HttpResponseMessage response = client.GetAsync("api/messaging/log/quantity").Result;  // Blocking call!
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // Parse the response body. Blocking!
        //        var r = response.Content.ReadAsAsync<int>().Result;
        //        return r;
        //    }
        //    else
        //    {

        //        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
        //    }
        //}
    }

}
