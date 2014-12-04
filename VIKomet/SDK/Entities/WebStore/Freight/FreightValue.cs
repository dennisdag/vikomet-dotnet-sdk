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
    public class FreightValue
    {
        [DataMember(Name = "CarrierId")]
        public string CarrierId { get; set; }

        /// <summary>
        /// Id da tabela de frete a partir da qual o frete foi calculado. Preenchido somente em casos de 
        /// frete calculado por tabelas de frete.
        /// </summary>
        [DataMember(Name = "FreightTableId")]
        public string FreightTableId { get; set; }

        /// <summary>
        /// Id da linha da tabela de frete a partir da qual o frete foi calculado. Preenchido somente em casos de 
        /// frete calculado por tabelas de frete.
        /// </summary>
        [DataMember(Name = "FreightTableValueId")]
        public string FreightTableValueId { get; set; }

        /// <summary>
        /// Id da integração a partir da qual o frete foi calculado. Preenchido somente em casos de 
        /// frete calculado por integração com outros sistemas, como por exemplo os Correios.
        /// </summary>
        [DataMember(Name = "FreightIntegrationId")]
        public string FreightIntegrationId { get; set; }

        [DataMember(Name = "DeliveryType")]
        public DeliveryType DeliveryType { get; set; }

        [DataMember(Name = "Modal")]
        public ModalType Modal { get; set; }

        [DataMember(Name = "Value")]
        public decimal Value { get; set; }

        [DataMember(Name = "DeliveryTimeInDays")]
        public int DeliveryTimeInDays { get; set; }
    }
}
