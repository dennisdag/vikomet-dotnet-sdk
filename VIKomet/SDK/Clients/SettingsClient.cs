
using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.Settings; 

namespace VIKomet.SDK.Clients
{
    public class SettingsClient : BaseClient
    {

        //private SettingsClient()
        //{
        //}

        public SettingsClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        //public Settings CreateAccount(Settings value)
        //{
        //    return new Settings();
        //}

        //public Settings GetByAccountDomain(string site)
        //{
        //     var cacheProvider = AppServices.Cache;
        //     return cacheProvider.Get<Settings>(this.GetType().FullName + "GetByAccountDomain" + site, DateTime.Now.AddMinutes(1), () =>
        //         {
        //             HttpResponseMessage response = client.GetAsync("api/settings/account/site/" + site).Result;  // Blocking call!
        //             if (response.IsSuccessStatusCode)
        //             {
        //                 // Parse the response body. Blocking!
        //                 var r = response.Content.ReadAsAsync<Settings>().Result;
        //                 return r;
        //             }
        //             else
        //             {
                         
        //                 throw ErrorParser(response.Content.ReadAsStringAsync().Result);
        //             }

        //         });
        //}
        //public void CreateInstance(NewInstance newInstance)
        //{
        //    var response = client.PostAsJsonAsync("api/settings/account", newInstance).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var r = response.Content.ReadAsAsync<NewInstance>().Result;
        //        // return r;
        //    }
        //    else
        //    {

        //        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
        //    }
        //}

        public int CountAPICalls(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/settings/account/apicalls/quantity/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
            return ValidateResponse<int>(response);
        }


        public Settings GetCurrentAccount()
        {
            return GetCurrentAccount(true);
        }

        public Settings GetCurrentAccount(bool useCache)
        {
            if (useCache)
            {
                var cacheProvider = AppServices.Cache;
                return cacheProvider.Get<Settings>(this.GetType().FullName + "GetCurrentAccount" + this.CacheString, DateTime.Now.AddMinutes(1), () =>
                {

                    HttpResponseMessage response = client.GetAsync("api/settings/account/id/" + this.CacheString).Result;  // Blocking call!
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        var r = response.Content.ReadAsAsync<Settings>().Result;
                        return r;
                    }
                    else
                    {

                        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                    }

                });
            }
            else
            {
                HttpResponseMessage response = client.GetAsync("api/settings/account/id/" + this.CacheString).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var r = response.Content.ReadAsAsync<Settings>().Result;
                    return r;
                }
                else
                {

                    throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                }
            }
        }

        //public Settings ExistsAccountId(string accountId)
        //{
        //    HttpResponseMessage response = client.GetAsync("api/settings/account/id/" + accountId).Result;  // Blocking call!
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // Parse the response body. Blocking!
        //        var r = response.Content.ReadAsAsync<Settings>().Result;
        //        return r;
        //    }
        //    else
        //    {

        //        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
        //    }
        //}


       
    }
}
