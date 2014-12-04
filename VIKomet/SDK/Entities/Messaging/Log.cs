using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Messaging.Log
{
    [Serializable]
    [DataContract]
    public class Log  
    {
       
        [DataMember(Name = "LogId")]
        public string LogId { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Timestamp")]
        public DateTime Timestamp { get; set; }

        [DataMember(Name = "Level")]
        public string Level { get; set; }

        [DataMember(Name = "ApplicationVersion")]
        public string ApplicationVersion { get; set; }

        [DataMember(Name = "DeviceId")]
        public string DeviceId { get; set; }

        [DataMember(Name = "Device")]
        public string Device { get; set; }

        [DataMember(Name = "Message")]
        public string Message { get; set; }
    }
    
}
