
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.Slug;

namespace VIKomet.SDK.Clients
{
    public class SlugClient : BaseClient
    { 

        public SlugClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public Slug GetByCompositeSlug(SlugType slugType, string slug)
        {
            HttpResponseMessage response = client.GetAsync("api/slug/type/" + Convert.ToInt32(slugType).ToString() +"/name/" + slug).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var marca = response.Content.ReadAsAsync<Slug>().Result;
                return marca;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }


    }
}
