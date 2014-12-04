using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using VIKomet.SDK.Entities.UserManagement;
using VIKomet.SDK.Entities.VIFrete;

namespace VIKomet.SDK.Entities.OrderManagement
{
    [Serializable]
    [DataContract]
    public class Order 
    {

        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember]
        public string AccountId { get; set; }

        [DataMember]
        public List<OrderLine> Lines { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public OrderStatus Status { get; set; }
        
        [DataMember]
        public List<OrderStatusFollowUp> AllStatus { get; set; }

        [DataMember]
        public List<string> PaymentIds { get; set; }

        // codigo de cupom
        [DataMember]
        public string CouponCode { get; set; }

        // vale-compras
        [DataMember]
        public string VoucherCode { get; set; }

        // dados de recorrencia do pedido (opcionais)

        /// <summary>
        /// Intervalo da recorrência em dias. Ex: 30 em 30 dias, 60 em 60 dias, etc. Informação de domínio do usuário.
        /// </summary>
        [DataMember]
        public int? RecurrenceInterval { get; set; }

        /// <summary>
        /// Quantidade de entregas ou ciclos da recorrência (assinatura) comprada. Informação de domínio do usuário.
        /// </summary>
        [DataMember]
        public long? RecurrenceBillingCycles { get; set; }

        /// <summary>
        /// Id do usuário que fechou o pedido.
        /// </summary>
        /// 
        [DataMember]
        public string UserId { get; set; }

        /// <summary>
        /// Email para acompanhamento do usuario (Checkout anonimo)
        /// </summary>
        [DataMember]
        public string UserEmail { get; set; }

        /// <summary>
        /// Id do endereço de cobrança do pedido.
        /// </summary>
        /// 
        [DataMember]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Id do endereço de entrega do pedido.
        /// </summary>
        /// 
        [DataMember]
        public Address ShippingAddress { get; set; }

        [DataMember(Name = "Freight")]
        public FreightValue Freight { get; set; }

        [DataMember(Name = "OrderDate")]
        public DateTime OrderDate { get; set; }
        
        public Order()
        {
            this.Lines = new List<OrderLine>();
            this.PaymentIds = new List<string>();
        }

    }

}
