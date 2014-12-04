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
    public class Configuration : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        /// <summary>
        /// Messaging Configuration´s Account id.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Google Cloud Message Api Key.
        /// </summary>
        [DataMember(Name = "GCMApiKey")]
        public string GCMApiKey { get; set; }

        /// <summary>
        /// Date of creation.
        /// </summary>
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Configuration´s Name.
        /// </summary>
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        
    }
}