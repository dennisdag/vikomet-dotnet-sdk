using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;



namespace VIKomet.SDK.Entities.Settings
{

    [Serializable]
    [DataContract]
    public class NewInstance
    {
        /// <summary>
        /// Instance name.
        /// </summary>
        [DataMember(Name = "InstanceName")]
        public string InstanceName { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [DataMember(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [DataMember(Name = "Password")]
        public string Password { get; set; }
 

    }
}
