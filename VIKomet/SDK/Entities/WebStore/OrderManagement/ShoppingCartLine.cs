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
    public class ShoppingCartLine
    {
        /// <summary>
        /// Id da linha.
        /// </summary>
        [DataMember(Name = "Id")]
        public string Id { get; set; }
        
        /// <summary>
        /// SkuId do item que a linha representa.
        /// </summary>
        [DataMember(Name = "InternalSkuId")]
        public string InternalSkuId { get; set; }

        /// <summary>
        /// Nome do item que a linha representa.
        /// </summary>
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Quantidade do sku.
        /// </summary>
        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Preço unitário.
        /// </summary>
        [DataMember(Name = "UnitPrice")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Imagem a aparecer no carrinho.
        /// </summary>
        [DataMember(Name = "ImagePath")]
        public string ImagePath { get; set; }

        /// <summary>
        /// Pricetags que alteram o valor da linha.
        /// </summary>
        [DataMember(Name = "PriceTags")]
        public List<PriceTag> PriceTags { get; set; }

        /// <summary>
        /// Flag informando se a linha é recorrente.
        /// </summary>
        [DataMember(Name = "Recurrent")]
        public bool Recurrent { get; set; }

        /// <summary>
        /// Prazo a partir do qual a linha não poderá mais ser vendida recorrentemente, ou seja, como assinatura. Informação de domínio do lojista.
        /// </summary>
        [DataMember(Name = "AllowRecurrenceBuyUntil")]
        public DateTime? AllowRecurrenceBuyUntil { get; set; }
        
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
        /// Item's Extended Properties.
        /// </summary>
        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

        public object GetExtendedProperty(string key)
        {
            if ((this.ExtendedProperties == null) || (this.ExtendedProperties.Count == 0))
            {
                return null;
            }

            if (this.ExtendedProperties.ContainsKey(key) == false)
            {
                return null;
            }

            return this.ExtendedProperties[key];
        }

        public decimal Total
        {
            get
            {
                decimal lineTotal = UnitPrice * Quantity;

                decimal totalDiscounts = decimal.Zero;
                foreach (PriceTag priceTag in PriceTags)
                {
                    decimal discountValue = decimal.Zero;
                    discountValue = priceTag.Value;
                    totalDiscounts = decimal.Add(totalDiscounts, discountValue);
                }

                return decimal.Add(lineTotal, totalDiscounts * -1);
            }

            private set { }
        }
        
        public ShoppingCartLine()
        {
            this.PriceTags = new List<PriceTag>();
        }

     }
}
