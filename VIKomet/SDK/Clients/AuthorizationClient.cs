using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.CMS;
using VIKomet.SDK.Entities.Security;
using VIKomet.SDK.Entities.UserManagement;
using VIKomet.SDK.Framework;

namespace VIKomet.SDK.Clients
{
    public class AuthorizationClient : BaseClient
    {
        public AuthorizationClient(bool isHTTPSCall) 
        {
            client = new HttpClient();
            if (isHTTPSCall)
            { 
                client.BaseAddress = new Uri("https://vikomet.com/");
            }
            else
            {
                client.BaseAddress = new Uri("http://localtest.me/");
            }
             
            //// Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public string GetClientCredentialToken(string accountId, string accountSecret)
        {

            // This is the anonymous function which gets called if the data is not in the cache.
            // This method is executed and whatever is returned, is added to the cache with the
            // passed in expiry time.
            var encoding = Encoding.GetEncoding("iso-8859-1");
           // string generatedToken;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("basic",
                    Convert.ToBase64String(encoding.GetBytes(
                string.Format("{0}:{1}", accountId, accountSecret))));

            
            var response = client.PostAsJsonAsync("api/authentication/token", new TokenRequest() { grant_type = "client_credentials"}).Result;

            var ret = ValidateResponse<Token>(response);
            return ret.access_token;

        }

        public string GetPasswordToken(User user, string accountId, string accountSecret)
        {

            //Pegar o authToken de um dicionario em memoria.
            //caso nao encontre, fazer a requisicao para o autenticador passando os caras comentados abaixo.

            if (accountId != null)
            {
                //var cacheProvider = AppServices.Cache;
                //var access_token = cacheProvider.Get<string>(accountId, DateTime.Now.AddDays(1), () =>
                //{
                // This is the anonymous function which gets called if the data is not in the cache.
                // This method is executed and whatever is returned, is added to the cache with the
                // passed in expiry time.
                var encoding = Encoding.GetEncoding("iso-8859-1");
 
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("basic",
                        Convert.ToBase64String(encoding.GetBytes(
                    string.Format("{0}:{1}", accountId, accountSecret))));

                var response = client.PostAsJsonAsync("api/authentication/token", new TokenRequest() { grant_type = "password", username = user.Username, password = user.Password }).Result;
                var ret = ValidateResponse<Token>(response);
                return ret.access_token;

            }
            throw new PermissionDeniedException();

        }

    }
}
