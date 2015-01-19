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
        /// Id de integração com sistemas legado.
        /// </summary>
        public string IntegrationId { get; set; }

        /// <summary>
        /// SkuId do item que a linha representa, informado no cadastro.
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Nome do item que a linha representa.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descrição do item que a linha representa.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Quantidade do sku.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Preço unitário.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Imagem a aparecer no carrinho.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Item's Extended Properties.
        /// </summary>
        public Dictionary<string, object> ExtendedProperties { get; set; }

    }

}
