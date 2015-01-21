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
    public class FreightRequest
    {
        [DataMember(Name = "ProductData")]
        public List<ProductData> Products { get; set; }

        [DataMember(Name = "PostalCodeFrom")]
        public long PostalCodeFrom { get; set; }

        [DataMember(Name = "PostalCodeTo")]
        public long PostalCodeTo { get; set; }
        
        public FreightRequest()
        {
            this.Products = new List<ProductData>();
        }
    }
}
