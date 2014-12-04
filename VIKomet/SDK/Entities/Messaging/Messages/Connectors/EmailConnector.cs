using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Messaging.Messages.Connectors
{
    [Serializable]
    [DataContract]
    public class EmailConnector
    {
        [DataMember(Name = "FromEmail")]
        public string FromEmail { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Body")]
        public string Body { get; set; }
    }

}
