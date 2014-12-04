using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.OrderManagement
{

    [Serializable]
    [DataContract]
    public class OrderStatusFollowUp
    {

        [DataMember]
        public OrderStatus Status { get; set; }

        [DataMember(Name = "Date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "UserId")]
        public string UserId { get; set; }
    }

}
