using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using VIKomet.SDK.Entities.VIFrete; 

namespace VIKomet.SDK.Entities.OrderManagement
{
    [Serializable]
    [DataContract]
    public class ShoppingCart  
    {

        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Usuário da aplicação dono do carrinho (usado na recuperação de carrinhos abandonados).
        /// </summary>
        [DataMember(Name = "UserId")]
        public string UserId { get; set; }

        [DataMember(Name = "UserIp")]
        public string UserIp { get; set; }

        [DataMember(Name = "Lines")]
        public List<ShoppingCartLine> Lines { get; set; }

        /// <summary>
        /// Lista das promoções concedidas.
        /// </summary>
        [DataMember(Name = "Promotions")]
        public List<VIKomet.SDK.Entities.Promotion.Promotion> Promotions { get; set; }
        
        /// <summary>
        /// Lista das pricetags geradas pelas promoções concedidas, utilizadas no cáculo do total do pedido.
        /// </summary>
        [DataMember(Name = "PriceTags")]
        public List<PriceTag> PriceTags { get; set; }

        // codigo de cupom
        [DataMember(Name = "CouponCode")]
        public string CouponCode { get; set; }

        // vale-compras
        [DataMember(Name = "VoucherCode")]
        public string VoucherCode { get; set; }

        // cep
        [DataMember(Name = "PostalCode")]
        public long PostalCode { get; set; }

        // dados do frete
        [DataMember(Name = "FreightValue")]
        public FreightValue FreightValue { get; set; }

        // tempo de entrega em dias
        [DataMember(Name = "DeliveryTime")]
        public long DeliveryTime { get; set; }

        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

        public decimal SubTotal
        {
            get
            {
                decimal subtotal = decimal.Zero;

                foreach (ShoppingCartLine line in Lines)
                {
                    subtotal = decimal.Add(subtotal, line.Total);
                }

                return subtotal;
            }
            private set { }
        }

        public decimal Discount
        {
            get
            {
                decimal discount = decimal.Zero;
                
                foreach (PriceTag priceTag in PriceTags)
                {
                    decimal discountValue = decimal.Zero;
                    discountValue = priceTag.Value;
                    discount = decimal.Add(discount, discountValue);
                }

                return discount;
            }
            private set { }
        }

        public decimal Freight
        {
            get
            {
                decimal freight = decimal.Zero;

                if (FreightValue != null)
                {
                    freight = FreightValue.Value;
                }

                return freight;
            }
            private set { }
        }
        
        public decimal Total { 
            get {
                return SubTotal + Freight + (Discount * -1);
            }
            private set { }
        }

        public ShoppingCart()
        {
            this.Lines = new List<ShoppingCartLine>();
            this.Promotions = new List<VIKomet.SDK.Entities.Promotion.Promotion>();
            this.PriceTags = new List<PriceTag>();
        }

    }
}
