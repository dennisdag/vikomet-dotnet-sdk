

using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.CMS;
using VIKomet.SDK.Entities.UserManagement;

namespace VIKomet.SDK.Clients
{
    public class CMSClient : BaseClient
    { 

      
        //public CMSClient(string storeDomain, string CacheString, string accountToken, string loggedUserAccessToken) : base(storeDomain, CacheString, accountToken, loggedUserAccessToken) { }
        public CMSClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public Category GetCategoryById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/cms/category/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Category>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Content GetContentByID(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/cms/content/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Content>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Content GetContentBySlug(string slug)
        {
            HttpResponseMessage response = client.GetAsync("api/cms/content/slug/" + slug).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Content>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Menu GetMenuByID(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/cms/menu/id/" + id + "?approved=true").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Menu>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public Menu GetMenuTreeByMainMenu()
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<Menu>(this.GetType().FullName + "_GetMenuTreeByMainMenu_" + this.CacheString, DateTime.Now.AddMinutes(1), () =>
                {

                    HttpResponseMessage response = client.GetAsync("api/cms/menu/mainmenu" + "?approved=true").Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var r = response.Content.ReadAsAsync<Menu>().Result;
                        return r;
                    }
                    else
                    {
                        
                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }
                });
        }

        public Menu GetMenuTreeById(string id)
        {
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<Menu>(this.GetType().FullName + "_GetMenuTreeById_" + this.CacheString, DateTime.Now.AddMinutes(1), () =>
            {
                HttpResponseMessage response = client.GetAsync("api/cms/menu/mainmenu/id/" + id + "?approved=true").Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var r = response.Content.ReadAsAsync<Menu>().Result;
                    return r;
                }
                else
                {
                    
                    throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                }
            });
        }

        public int CountMenus()
        {
            HttpResponseMessage response = client.GetAsync("api/cms/menu/quantity").Result;  // Blocking call!
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

        public int CountCategories()
        {
            HttpResponseMessage response = client.GetAsync("api/cms/category/quantity").Result;  // Blocking call!
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

        public int CountContents()
        {
            HttpResponseMessage response = client.GetAsync("api/cms/content/quantity").Result;  // Blocking call!
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
