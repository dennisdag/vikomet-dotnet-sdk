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
    public class RecurrenceLine
    {
        /// <summary>
        /// Intervalo da recorrência em dias. Ex: 30 em 30 dias, 60 em 60 dias, etc. Informação de domínio do usuário.
        /// </summary>
        [DataMember(Name = "RecurrenceInterval")]
        public int? RecurrenceInterval { get; set; }

        /// <summary>
        /// Quantidade de entregas ou ciclos da recorrência (assinatura) comprada. Informação de domínio do usuário.
        /// </summary>
        [DataMember(Name = "RecurrenceBillingCycles")]
        public long? RecurrenceBillingCycles { get; set; }

        /// <summary>
        /// Quantidade do sku.
        /// </summary>
        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Identificador do usuário.
        /// </summary>
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// Data de criação da linha de recorrência.
        /// </summary>
        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}
