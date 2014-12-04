using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Messaging.Messages
{
    public class QueueMessage
    {
        [DataMember(Name = "QueueMessageId")]
        public string QueueMessageId { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }
        
        [DataMember(Name = "Body")]
        public string Body { get; set; }

        [DataMember(Name = "Recipient")]
        public string Recipient { get; set; }

        [DataMember(Name = "RecipientType")]
        public int RecipientType { get; set; }

        [DataMember(Name = "ConfigurationId")]
        public string ConfigurationId { get; set; }
    }
}
