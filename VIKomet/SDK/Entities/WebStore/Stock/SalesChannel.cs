using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Stock
{
    [Serializable]
    [DataContract]
    public class SalesChannel 
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "SalesChannelId")]
        public string SalesChannelId { get; set; }

        [DataMember(Name = "SalesChannelName")]
        public string SalesChannelName { get; set; }

    }
}
