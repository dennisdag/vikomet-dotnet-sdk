using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.VIFrete
{
    [Serializable]
    [DataContract]
    public class FreightTable
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }
        
        [DataMember(Name = "CarrierId")]
        public string CarrierId { get; set; }

        [DataMember(Name = "Private")]
        public bool Private { get; set; }

        [DataMember(Name = "DateFrom")]
        public DateTime DateFrom { get; set; }

        [DataMember(Name = "DateTo")]
        public DateTime DateTo { get; set; }

        [DataMember(Name = "CubedWeightFactor")]
        public decimal CubedWeightFactor { get; set; }

        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

    }
}
