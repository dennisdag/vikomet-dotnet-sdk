
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
    public class MessageGateway {

        /// <summary>
        /// Gateway´s Name.
        /// </summary>
        [DataMember(Name = "Name")]
        public string Name { get; set; }


        /// <summary>
        /// Gateway's Slug.
        /// </summary>
        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gateway´s Account id.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gateway Owner Identifier.
        /// </summary>
        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can Read messages.
        /// </summary>
        [DataMember(Name = "UsersCanGET")]
        public List<string> UsersCanGET { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can POST messages.
        /// </summary>
        [DataMember(Name = "UsersCanPOST")]
        public List<string> UsersCanPOST { get; set; }


        /// <summary>
        /// Date of creation.
        /// </summary>
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Direct Messages route.
        /// </summary>
        [DataMember(Name = "DirectMessageRoute")]
        public bool DirectMessageRoute { get; set; }

       
    }
    
}
