using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VI.Engine.Entity.Webstore.Freight
{
    [Serializable]
    [DataContract]
    public class FreightTableValue
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "FreightTableId")]
        public string FreightTableId { get; set; }

        /// <summary>
        /// Cep inicial da faixa de cep (inclusivo).
        /// </summary>
        [DataMember(Name = "PostalCodeFrom")]
        public long PostalCodeFrom { get; set; }

        /// <summary>
        /// Cep final da faixa de cep (exclusivo).
        /// </summary>
        [DataMember(Name = "PostalCodeTo")]
        public long PostalCodeTo { get; set; }

        /// <summary>
        /// Peso mínimo da faixa em gramas (inclusivo).
        /// </summary>
        [DataMember(Name = "MinWeight")]
        public decimal MinWeight { get; set; }

        /// <summary>
        /// Peso máximo da faixa em gramas (exclusivo).
        /// </summary>
        [DataMember(Name = "MaxWeight")]
        public decimal MaxWeight { get; set; }

        /// <summary>
        /// Volume máximo da faixa em centímetros cúbicos (excusivo).
        /// </summary>
        [DataMember(Name = "MaxVolume")]
        public decimal MaxVolume { get; set; }

        /// <summary>
        /// Valor absoltuto do frete.
        /// </summary>
        [DataMember(Name = "Value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Valor a ser utilizado para calcular adicional de frete sobre o preço.
        /// </summary>
        [DataMember(Name = "ValueByPrice")]
        public decimal ValueByPrice { get; set; }

        /// <summary>
        /// Valor a ser utilizado para calcular adicional de frete sobre o peso excedente.
        /// </summary>
        [DataMember(Name = "ValueByWeight")]
        public decimal ValueByWeight { get; set; }
        
        /// <summary>
        /// Tempo de entrega em dias.
        /// </summary>
        [DataMember(Name = "DeliveryTimeInDays")]
        public int DeliveryTimeInDays { get; set; }

    }
}
