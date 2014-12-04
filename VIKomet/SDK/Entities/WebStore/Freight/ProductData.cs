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
    public class ProductData
    {
        [DataMember(Name = "Length")]
        public decimal Length { get; set; }

        [DataMember(Name = "Width")]
        public decimal Width { get; set; }

        [DataMember(Name = "Height")]
        public decimal Height { get; set; }

        [DataMember(Name = "Weight")]
        public decimal Weight { get; set; }

        [DataMember(Name = "Price")]
        public decimal Price { get; set; }

        [DataMember(Name = "IsVirtual")]
        public bool IsVirtual { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

    }
}
