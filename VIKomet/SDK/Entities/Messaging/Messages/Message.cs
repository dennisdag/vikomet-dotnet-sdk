
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Messaging.Messages
{
    [Serializable]
    [DataContract]
    public class Message : ICloneable 
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Message´s Account id.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Message's Owner Identifier.
        /// </summary>
        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Date of creation.
        /// </summary>
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Message.
        /// </summary>
        [DataMember(Name = "Body")]
        public string Body { get; set; }

    }
    
}
