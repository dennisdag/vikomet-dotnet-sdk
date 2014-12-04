

using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.UserManagement; 

namespace VIKomet.SDK.Clients
{
    public class CustomerClient : BaseClient
    {

        
        public CustomerClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }
        
        //TODO: Devolver dados sensiveis mascarados
        public User GetLoggedCustomerById(string id)
        { 
            var cacheProvider = AppServices.Cache;
            return cacheProvider.Get<User>(this.GetType().FullName + "api/usersandpermissions/user/id/" + id, DateTime.Now.AddMinutes(10), () =>
            {
                HttpResponseMessage response = client.GetAsync("api/usersandpermissions/user/id/" + id).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    var r = response.Content.ReadAsAsync<User>().Result;
                    return r;
                }
                else
                {

                    throw ErrorParser(response.Content.ReadAsStringAsync().Result);
                }
            });
        }

        public User CreateCustomer(User user)
        {
            var response = client.PostAsJsonAsync("api/usersandpermissions/user", user).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<User>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public User UpdateLoggedCustomer(User user)
        {
            var response = client.PutAsJsonAsync("api/usersandpermissions/user/" + user.UserId, user).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<User>().Result;
                return r;
            }
            else
            {
                
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }
        //TODO: Criar: Create address, list addresses, update address: Retirar: Alteracao de endereco no update user.



        public void ChangePassword(ChangePasswordData changePasswordData)
        {
            var response = client.PostAsJsonAsync("api/usersandpermissions/user/changepassword", changePasswordData).Result;
            if (!response.IsSuccessStatusCode)
            { 
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public string GeneratePasswordReset(ResetPasswordData resetPasswordData)
        {
            var response = client.PostAsJsonAsync("api/usersandpermissions/user/generatepasswordreset", resetPasswordData).Result;
            if (response.IsSuccessStatusCode)
            {
                var r = response.Content.ReadAsAsync<string>().Result;
                return r;
            }
            else
            { 
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void ResetPasswordWithToken(ResetPasswordData resetPasswordData)
        {
            var response = client.PostAsJsonAsync("api/usersandpermissions/user/resetpassword", resetPasswordData).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public User GetUserById(string id)
        {
            HttpResponseMessage response = client.GetAsync("api/usersandpermissions/user/id/" + id).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<User>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }

        }

        //public User CreateNewUser(User user, string accountid)
        //{
        //    //TODO: como passar accountid?
        //    var response = client.PostAsJsonAsync("api/usersandpermissions/user/createnewuser ", user, accountid).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var r = response.Content.ReadAsAsync<User>().Result;
        //        return r;
        //    }
        //    else
        //    {

        //        throw ErrorParser(response.Content.ReadAsStringAsync().Result);
        //    }
        //}


    }
}
