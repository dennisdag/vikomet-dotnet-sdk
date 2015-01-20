using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.UserManagement;
using VIKomet.SDK.Entities.VIFrete;

namespace VIKomet.SDK.Entities.OrderManagement
{
    [Serializable]
    [DataContract]
    public class Recurrence 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Instance Identifier.
        /// </summary>
        [DataMember]
        public string AccountId { get; set; }

        //Id do usuário que fechou o pedido.
        /// <summary>
        /// Identifier of the User that made the order.
        /// </summary>
        [DataMember]
        public string UserId { get; set; }

        //Email para acompanhamento do usuario (Checkout anonimo)
        /// <summary>
        /// User email for order monitoring purposes. (Anonymous checkout)
        /// </summary>
        [DataMember]
        public string UserEmail { get; set; }

        /// <summary>
        /// Recurrence Date.
        /// </summary>
        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Recurrence last update.
        /// </summary>
        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

        //Intervalo da recorrência em dias. Ex: 30 em 30 dias, 60 em 60 dias, etc. Informação de domínio do usuário.
        /// <summary>
        /// Recurrence Interval in days. e.g. every 30, 60 or 90 days.
        /// </summary>
        [DataMember]
        public int RecurrenceInterval { get; set; }

        /// <summary>
        /// Quantity of deliveries in the purchased recurrence.
        /// </summary>
        [DataMember]
        public long? RecurrenceBillingCycles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "Lines")]
        public List<RecurrenceLine> Lines { get; set; }

        public Recurrence()
        {
            this.Lines = new List<RecurrenceLine>();
        }

    }
}
