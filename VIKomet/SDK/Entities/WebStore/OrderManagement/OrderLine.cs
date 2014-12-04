using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIKomet.SDK.Entities.Stock; 

namespace VIKomet.SDK.Entities.OrderManagement
{
    public class OrderLine
    {

        /// <summary>
        /// SkuId do item que a linha representa, gerado no banco.
        /// </summary>
        public string InternalSkuId { get; set; }
        
        /// <summary>
        /// SkuId do item que a linha representa, informado no cadastro.
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Nome do item que a linha representa.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Quantidade do sku.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Preço unitário.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Imagem do produto.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Total da linha.
        /// </summary>
        public decimal Total
        {
            get
            {
                return UnitPrice * Quantity;
            }

            private set { }
        }

        /// <summary>
        /// Pricetags que alteram o valor da linha.
        /// </summary>
        public List<PriceTag> PriceTags { get; set; }

        /// <summary>
        /// Reservas dos itens do pedido.
        /// </summary>
        public List<Reserve> Reserves { get; set; }
        
        /// <summary>
        /// Compras dos itens do pedido.
        /// </summary>
        public List<Purchase> Purchases { get; set; }

        /// <summary>
        /// Item's Extended Properties.
        /// </summary> 
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

        public OrderLine()
        {
            this.Reserves = new List<Reserve>();
            this.Purchases = new List<Purchase>();
            this.PriceTags = new List<PriceTag>();
        }


        
    }
}
