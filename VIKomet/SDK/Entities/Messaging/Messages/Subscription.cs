
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
    public class Subscription  
    {
        /// <summary>
        /// Subscription identifier.
        /// </summary>
        [DataMember(Name = "SubscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Subscription´s Account id.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Subscription´s Name.
        /// </summary>
        [DataMember(Name = "Name")]
        public string Name { get; set; }


        /// <summary>
        /// Subscription´s Slug.
        /// </summary>
        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Subscription´s Configuration id.
        /// </summary>
        [DataMember(Name = "ConfigurationId")]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// Subscription´s Owner.
        /// </summary>
        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

        /// <summary>
        /// List of Users that can subscribe to this subscription.
        /// </summary>
        [DataMember(Name = "UsersCanSubscribe")]
        public List<string> UsersCanSubscribe { get; set; }

        /// <summary>
        /// MessageGateway´s id.
        /// </summary>
        [DataMember(Name = "MessageGatewayId")]
        public string MessageGatewayId { get; set; }

         /// <summary>
        /// Date of creation.
        /// </summary>
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }


    }
}