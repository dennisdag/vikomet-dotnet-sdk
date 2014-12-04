using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Payment
{
    [Serializable]
    [DataContract]
    public class Payment
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember]
        public string AccountId { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public string OrderId { get; set; }

        [DataMember]
        public decimal Value { get; set; }

        [DataMember]
        public PaymentStatus Status { get; set; }

        /// <summary>
        /// Data de criação do pagamento
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// Data da última atualização do pagamento.
        /// </summary>
        [DataMember]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Id do pagamento, fornecido pelo gateway que processou o pagamento. Ex: MOIP, PagSeguro, etc.
        /// </summary>
        [DataMember]
        public string TransactionId { get; set; }
    }

}
