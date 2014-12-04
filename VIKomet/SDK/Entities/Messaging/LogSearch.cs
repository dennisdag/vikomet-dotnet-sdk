
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace VIKomet.SDK.Entities.Messaging.Log
{
    [Serializable]
    [DataContract(Name = "LogSearch")]
 
    public class LogSearch
    {
        public string Id { get; set; }

        [DataMember(Name = "IDLogKey")]
        public string IDLogKey
        {   //Propriedade criada para o Id da heranca ficar no mesmo nivel no json
            get
            { return Id; }
            set
            {
                Id = value;
            }
            //So mantem o Set, pq senao nao serializa para todos os tipos
        }


        [DataMember(Name = "AccountId")]  
        public string AccountId { get; set; }
        
        [DataMember(Name = "Timestamp")]
        public DateTime Timestamp { get; set; }

        [DataMember(Name = "Level", EmitDefaultValue = false)]
        public string Level { get; set; }

        [DataMember(Name = "ApplicationVersion", EmitDefaultValue = false)]
        public string ApplicationVersion { get; set; }

        [DataMember(Name = "DeviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        [DataMember(Name = "Device", EmitDefaultValue = false)]
        public string Device { get; set; }

        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }
       
    }
}
