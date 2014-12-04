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
    public class Subscriber  
    {
        /// <summary>
        /// Subscriber identifier.
        /// </summary>
        [DataMember(Name = "SubscriberId")]
        public string SubscriberId { get; set; }

        /// <summary>
        /// Subscriber´s Account id.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Subscriber´s Subscription id.
        /// </summary>
        [DataMember(Name = "SubscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// User Identifier.
        /// </summary>
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// Date of creation.
        /// </summary>
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Subscriber Recipient.
        /// </summary>
        [DataMember(Name = "Recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// Subscriber Recipient Type.
        /// </summary>
        [DataMember(Name = "RecipientType")]
        public int RecipientType { get; set; }

    }
    
}
