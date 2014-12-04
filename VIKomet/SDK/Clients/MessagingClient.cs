
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
using VIKomet.SDK.Entities.Messaging.Messages;

namespace VIKomet.SDK.Clients
{
    public class MessagingClient : BaseClient
    {
        
        public MessagingClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public void SendMessage(Message message, string messageGatewaySlug)
        {
            var response = client.PostAsJsonAsync("api/messaging/messages/" + messageGatewaySlug  + "/send", message).Result;
            if (response.IsSuccessStatusCode)
            {
                //var r = response.Content.ReadAsAsync<Item>().Result;
               // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
         
   }

}
