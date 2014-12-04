using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Security
{
    public class Token
    {
        //You may use this token to invoke VICommerce REST API methods. Pass this token as a parameter with each REST API method call. Read how to make an API call below.
        public string access_token { get; set; }

        //The duration in seconds of the access token's lifetime. Note: This field is only returned when the token has an expiration time. If this field is not available then the token will not expire.
        public long expires_in { get; set; }

        public string token_type { get; set; }

        public string user_id { get; set; }
    }
}
