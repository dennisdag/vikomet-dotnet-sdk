using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Clients
{
    public class AccountClient : BaseClient
    {
        
        public AccountClient(string access_token, string cacheString, bool isHTTPSCall) : base(access_token, cacheString, isHTTPSCall) { }

        

        public long CountUsers(DateTime dateFrom)
        {
            HttpResponseMessage response = client.GetAsync("api/usersandpermissions/user/quantity/" + dateFrom.ToString("yyyy-MM-dd")).Result;  // Blocking call!
            return ValidateResponse<long>(response);
           
        }

      
        public int CountUsers()
        {
            HttpResponseMessage response = client.GetAsync("api/usersandpermissions/user/quantity/").Result;  // Blocking call!
            return ValidateResponse<int>(response);
        }
    }
}
