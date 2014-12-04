
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
    public class ResetPasswordData  
    {
        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "NewPassword")]
        public string NewPassword { get; set; }

        [DataMember(Name = "PasswordVerificationToken")]
        public string PasswordVerificationToken { get; set; }

    }
}
