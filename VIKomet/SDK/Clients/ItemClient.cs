
using VIKomet.Framework.Common;
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

namespace VIKomet.SDK.Clients
{
    public class ItemClient : BaseClient
    {
        
        public ItemClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public Item GetItemById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/datastorage/item/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Item>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
        
        public PagedList<ItemSearch> Search(string q, string ep, string itemTypeId, double lat, double lon, double distance, string sortCriteria, int page, int itemsPerPage, string fields)
        {
            return Search(q, ep, itemTypeId, null, lat, lon, distance, sortCriteria, page, itemsPerPage, null, fields);

        }
        public PagedList<ItemSearch> Search(string q, string ep, string itemTypeId, string ownerId, double? lat, double? lon, double? distance, string sortCriteria, int page, int itemsPerPage, string fields)
        {
            return Search(q, ep, itemTypeId, ownerId, lat, lon, distance, sortCriteria, page, itemsPerPage, null,fields);
        }
        public PagedList<ItemSearch> Search(string q, string ep, string itemTypeId, string ownerId, double? lat, double? lon, double? distance, string sortCriteria, int page, int itemsPerPage, int? status, string fields)
        {
 
            string url = "api/datastorage/item/search?z=";

            if (!string.IsNullOrEmpty(q))
            {
                url = url + "&q=" + HttpUtility.UrlEncode(q);
            }

            if (!string.IsNullOrEmpty(itemTypeId))
            {
                url = url + "&itemTypeId=" + HttpUtility.UrlEncode(itemTypeId);
            }

            if (!string.IsNullOrEmpty(fields))
            {
                url = url + "&fields=" + HttpUtility.UrlEncode(fields);
            }
              
            if (!string.IsNullOrEmpty(ownerId))
            {
                url = url + "&ownerId=" + HttpUtility.UrlEncode(ownerId);
            }

            if (!string.IsNullOrEmpty(ep))
            {
                url = url + "&ep=" + HttpUtility.UrlEncode(ep);
            }

            if (!string.IsNullOrEmpty(sortCriteria))
            {
                url = url + "&sortCriteria=" + HttpUtility.UrlEncode(sortCriteria);
            }

            if (lat != null)
            {
                url = url + "&lat=" + HttpUtility.UrlEncode(lat.ToString());
            }

            if (lon != null)
            {
                url = url + "&lon=" + HttpUtility.UrlEncode(lon.ToString());
            }

            if (distance != null)
            {
                url = url + "&distance=" + HttpUtility.UrlEncode(distance.ToString());
            }
             
            if (page != 0)
            {
                url = url + "&page=" + page.ToString();
            }

            if (itemsPerPage != 0)
            {
                url = url + "&itemsPerPage=" + itemsPerPage.ToString();
            }

            if (status != null)
            {
                url = url + "&status=" + HttpUtility.UrlEncode(status.ToString());
            }

            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<ItemSearch>>().Result;
                return r;
            }
            else
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }
         
        public PagedList<ItemSearch> SearchByItemOwner(string itemTypeId, string loggedUserId)
        {
            return Search(null, null, itemTypeId, loggedUserId, null, null, null, "", 1, 100000, null);
        }

        public void InsertItem(Item item)
        {
            var response = client.PostAsJsonAsync("api/datastorage/item", item).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Item>().Result;
               // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void UpdateItem(Item item)
        {
            var response = client.PutAsJsonAsync("api/datastorage/item/" + item.ItemId, item).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Item>().Result;
              //  return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void DeleteItem(string itemId)
        {
            var response = client.DeleteAsync("api/datastorage/item/" + itemId).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<Item>().Result;
              //  return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
        public void SetExtendedProperty(string itemId, string propertyName, object value)
        {
            var response = client.PutAsJsonAsync("api/datastorage/item/" + itemId + "/extendedproperty/" + propertyName, value).Result;
            ValidateResponse(response);
        }

        public dynamic GetExtendedProperty(string itemId, string propertyName)
        {
            HttpResponseMessage response = client.GetAsync("api/datastorage/item/" + itemId + "/extendedproperty/" + propertyName).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var itemType = response.Content.ReadAsAsync<dynamic>().Result;
                return itemType;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
        
        public ItemType GetItemTypeById(string id)
        {

            HttpResponseMessage response = client.GetAsync("api/datastorage/itemtemplate/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var itemType = response.Content.ReadAsAsync<ItemType>().Result;
                return itemType;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public int Count()
        {
            HttpResponseMessage response = client.GetAsync("api/datastorage/item/count/quantity").Result;  // Blocking call!
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
