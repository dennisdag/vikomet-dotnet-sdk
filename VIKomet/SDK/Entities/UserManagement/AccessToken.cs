
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.UserManagement
{
    [Serializable]
    [DataContract]
    public class AccessToken 
    {
        [DataMember(Name = "Id")]
        public string ItemId{ get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "UserID")]
        public string UserID { get; set; }

        //The duration in seconds of the access token's lifetime. Note: This field is only returned when the token has an expiration time. If this field is not available then the token will not expire.
        [DataMember(Name = "ExpiresIn")]
        public long ExpiresIn { get; set; }

        [DataMember(Name = "TokenType")]
        public string TokenType { get; set; }

        [DataMember(Name = "Scope")]
        public List<string> Scope { get; set; }
         
        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

    }
}
