using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.OrderManagement
{
    /// <summary>
    /// Alteração do preço dos produtos. Podem ser negativas para descontos (gerados por promoções) ou positivas para acréscimos (gerados por tributos).
    /// </summary>
    [DataContract]
    public class PriceTag
    {
        [DataMember(Name = "Source")]
        public string Source { get; set; }

        [DataMember(Name = "Value")]
        public decimal Value { get; set; }
    }

}
