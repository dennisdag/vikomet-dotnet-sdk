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
    public class HttpConnector
    {
        [DataMember(Name = "URL")]
        public string URL { get; set; }

        [DataMember(Name = "Headers")]
        public List<KeyValuePair<string,string>> Headers{ get; set; }
    }
}
