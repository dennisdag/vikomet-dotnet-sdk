

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.WebStore.Checkout;
using VIKomet.SDK.Entities.OrderManagement;
using VIKomet.SDK.Entities.Settings;
using System.Web;
using VIKomet.Framework.Common; 

namespace VIKomet.SDK.Clients
{
    public class OrderManagementClient : BaseClient
    {

         
        public OrderManagementClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        public string CreateShoppingCart(string userId, string ip)
        {
            string apiCall = "api/webstore/om/cart/";
            ShoppingCart cart = new ShoppingCart();
            cart.UserId = userId;
            cart.UserIp = ip;
            HttpResponseMessage response = client.PostAsJsonAsync(apiCall, cart).Result;  // Blocking call!
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

        public void GetAssociateShoppingCart(string cartId, string userId)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/associate/{0}/{1}", cartId, userId)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void GetMergeShoppingCarts(string cartIdFrom, string cartIdTo)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/merge/{0}/{1}", cartIdFrom, cartIdTo)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public ShoppingCart GetShoppingCartById(string cartId)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/cart/id/" + cartId).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public PagedList<Order> GetAllOrders()
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/order?status=&orderIdPart=&page=").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<Order>>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public PagedList<Order> GetAllOrdersFromLoggedUser(string userId)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/order/user/" + userId).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<PagedList<Order>>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public string GetShoppingCartIdByUserId(string userId)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/cart/userid/" + userId).Result;  // Blocking call!
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
       
        public void AddItemToShoppingCart(string cartId, string internalSkuId, int quantity)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/add/{0}/{1}/{2}", cartId, internalSkuId, quantity)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
               // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void AddItemToShoppingCart(string cartId, string internalSkuId, int quantity, int recurrenceIntervalInDays)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/add/{0}/{1}/{2}/{3}", cartId, internalSkuId, quantity, recurrenceIntervalInDays)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public void AddItemToShoppingCart(string cartId, string internalSkuId, int quantity, int recurrenceIntervalInDays, string ep, string description)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/add/{0}/{1}/{2}/{3}?ep={4}&description={5}", cartId, internalSkuId, quantity, recurrenceIntervalInDays, HttpUtility.UrlEncode(ep), description)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        public void AddItemToShoppingCart(string cartId, string internalSkuId, int quantity, int recurrenceIntervalInDays, long billingCycles)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/add/{0}/{1}/{2}/{3}/{4}", cartId, internalSkuId, quantity, recurrenceIntervalInDays, billingCycles)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void UpdateShoppingCart(string cartId, string shoppingCartLineId, int quantity)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/update/{0}/{1}/{2}", cartId, shoppingCartLineId, quantity)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void DeleteShoppingCartLine(string cartId, string shoppingCartLineId)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/delete/{0}/{1}", cartId, shoppingCartLineId)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public bool DoesCartExist(string cartId)
        {
            if (string.IsNullOrEmpty(cartId))
            {
                return false;
            }
            
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/exist/{0}", cartId)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<bool>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public Order GetOrderById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/order/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<Order>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public long CountAbandonedCarts(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/cart/abandoned/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
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

        public long CountAnonymousAbandonedCarts(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/cart/anonymous/abandoned/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
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

        public List<KeyValuePair<string, long>> GetTopProducts(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/order/top/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<KeyValuePair<string, long>>>().Result;
                if(r.Count > 5)
                {
                    return r.Take(5).ToList();
                }
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public List<KeyValuePair<string, long>> GetOrdersByStatus(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/webstore/om/order/stats/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<KeyValuePair<string, long>>>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
        
        public List<Order> Purchase(string cartId, string userId, string billingAddressId, string shippingAddressId)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/purchase/{0}/{1}/{2}/{3}", cartId, userId, billingAddressId, shippingAddressId)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<List<Order>>().Result;
                return r;
            }
            else
           {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            } 
        }

        public List<Order> Purchase(Checkout checkout)
        {
            var response = client.PostAsJsonAsync("api/webstore/om/cart/checkout", checkout).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<List<Order>>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
             
        }

        public void UpdateShoppingCartPostalCode(string cartId, string postalCode)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/cart/update/{0}/{1}", cartId, postalCode)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<ShoppingCart>().Result;
                // return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public long CountOrders()
        {
            HttpResponseMessage response = client.GetAsync(string.Format("api/webstore/om/order/quantity")).Result;  // Blocking call!
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
