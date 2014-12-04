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
    public class ChangePasswordData  
    { 
        [DataMember(Name = "Username")]
        public string Username { get; set; }
          
        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "NewPassword")]
        public string NewPassword { get; set; } 

    }
}
