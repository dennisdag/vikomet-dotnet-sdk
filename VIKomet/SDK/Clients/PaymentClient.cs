using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.Payment;

namespace VIKomet.SDK.Clients
{
    public class PaymentClient : BaseClient
    {
        public PaymentClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }



        public int PaymentGetCount()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/payment/count").Result;  // Blocking call!
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


        public Payment GetPaymentById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/payment/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Payment>().Result;
                return r;
            }
            else
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
        

        public string GenerateBoleto(decimal orderTotal, string userId)
        {
            HttpResponseMessage response = client.GetAsync("api/pvt/payment/boleto?orderTotal=" + orderTotal.ToString(new CultureInfo("en-US")) + "&userId=" + userId).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<string>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

    }
}
