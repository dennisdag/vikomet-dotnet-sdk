

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
using VIKomet.Framework.Common;

namespace VIKomet.SDK.Clients
{
    public class LogClient : BaseClient
    {
        

        public LogClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public Log GetLogById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/messaging/log/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Log>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
        
        public PagedList<LogSearch> Search(string q, string ep, string itemTypeId, double lat, double lon, double distance, string sortCriteria, int page, int itemsPerPage, string fields)
        {
            string url = "api/messaging/log/search?q=" + q + "&itemtypeId=" + itemTypeId + "&ep=" + HttpUtility.UrlEncode(ep) + "&lat=" + HttpUtility.UrlEncode(lat.ToString()) + "&lon=" + HttpUtility.UrlEncode(lon.ToString()) + "&distance=" + HttpUtility.UrlEncode(distance.ToString()) + "&sortCriteria=" + sortCriteria + "&page=" + page.ToString() + "&itemsPerPage=" + itemsPerPage.ToString() + "&fields=" + fields;

            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<LogSearch>>().Result;
                return r;
            }
            else
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
         
        public Log Log(Log item)
        {
            var response = client.PostAsJsonAsync("api/messaging/log", item).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Log>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public long Count()
        {
            HttpResponseMessage response = client.GetAsync("api/messaging/log/quantity").Result;  // Blocking call!
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
