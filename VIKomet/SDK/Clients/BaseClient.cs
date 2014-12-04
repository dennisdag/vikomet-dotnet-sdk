


using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VIKomet.SDK.Framework;

namespace VIKomet.SDK.Clients
{
    public abstract class BaseClient
    {
        protected HttpClient client;
        protected string access_token;
        protected string caller_host;
        protected string _cacheString;

        public T ValidateResponse<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var r = response.Content.ReadAsAsync<T>().Result;
                return r;
            }
            else
            {

                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void ValidateResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw ErrorParser(response.Content.ReadAsStringAsync().Result);
            }
        }

        protected BaseClient()
        {
        }

        //private BaseClient()
        //{
        //    //client = new HttpClient();
        //    //client.BaseAddress = new Uri("http://localtest.me/");

        //    ////client.BaseAddress = new Uri("http://vikomet.com/");
        //    //// Add an Accept header for JSON format.
        //    //client.DefaultRequestHeaders.Accept.Add(
        //    //    new MediaTypeWithQualityHeaderValue("application/json"));
        //}

        protected string CacheString
        {
            get
            {
                return _cacheString;
            }
        }


        public BaseClient(string accessToken, string accountId, bool isHTTPSCall)
        {
            this.access_token = accessToken;
            this._cacheString = accountId;

            client = new HttpClient();

            if (isHTTPSCall)
            {
                client.BaseAddress = new Uri("https://vikomet.com/");
            }
            else
            {
                client.BaseAddress = new Uri("http://vikomet.com/");
            }
             
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (String.IsNullOrEmpty(ip) || ip.Count() < 8)
                {
                    ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }

                if (String.IsNullOrEmpty(ip) || ip.Count() < 8)
                {
                    ip = System.Web.HttpContext.Current.Request.UserHostAddress;
                }




                if (!String.IsNullOrEmpty(ip) && (ip != "::1"))
                {
                    client.DefaultRequestHeaders.Add("X_FORWARDED_FOR", ip);
                }

                string agent = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"];
                client.DefaultRequestHeaders.Add("USER_AGENT", agent);

                string connection = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_CONNECTION"];
                client.DefaultRequestHeaders.Add("CONNECTION", connection);

            }
            catch (Exception ex)
            {
                //TODO: JVALLE - Ao estar fora de um contexto HTTP, o que devemos fazer?
            }

            if (!string.IsNullOrEmpty(accessToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
            else
            {
                throw new ApplicationException("Unauthorized");
            }
        }

        public Exception ErrorParser(string err)
        {
            Error error = null;

            //TODO: Tratar erro em HTML (exception careta)
            if (err.Contains("<xml"))
            {
                TextReader reader = new StringReader(err);
                var s = new System.Xml.Serialization.XmlSerializer(typeof(Error));
                error = (Error)s.Deserialize(reader);
            }
            else
            {
                error = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(err);
            }

            switch (error.Type)
            {
                case "VI.Engine.BusinessException":
                case "BusinessException":
                    return new BusinessException(error.ExceptionMessage, error.Code);
                case "VI.Engine.PermissionDeniedException":
                case "PermissionDeniedException":
                    return new PermissionDeniedException(error.ExceptionMessage, error.Code);
                case "VI.Engine.ValidationException":
                case "ValidationException":
                    return new ValidationException(error.ExceptionMessage, error.Code);
                case "VI.Engine.ApplicationException":
                case "ApplicationException":
                    return new ApplicationException(error.ExceptionMessage);
                default:
                    return new Exception(error.ExceptionMessage);
            }
        }

    }
}
