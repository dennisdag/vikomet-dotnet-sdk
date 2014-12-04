using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Stock
{
    [Serializable]
    [DataContract]
    public class Stock 
    {
        
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember]
        public string InventoryId { get; set; }

        /// <summary>
        /// Informa se o estoque se refere a kit.
        /// </summary>
        [DataMember]
        public bool KitInventory { get; set; }
        
        /// <summary>
        /// Ids dos filhos do kit relativo ao estoque (preenchidos apenas se o estoque se refere a kit) .
        /// </summary>
        [DataMember]
        public List<string> KitChildrenSkuIds { get; set; }
        
        [DataMember]
        public string AccountId { get; set; }

        /// <summary>
        /// SkuId do estoque em questão (id gerado pelo banco).
        /// </summary>
        [DataMember]
        public string InternalSkuId { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// SkuId do estoque em questão (id preenchido manualmente).
        /// </summary>
        [DataMember]
        public string SkuId { get; set; }

        [DataMember]
        public StockType StockType { get; set; }

        [DataMember]
        public string FulfillmentCenterId { get; set; }

        [DataMember]
        public int AvailableQuantity { get; set; }

        [DataMember]
        public int WarningQuantity { get; set; }

        [DataMember]
        public TimeSpan ReserveExpirationTime { get; set; }
        
        [DataMember]
        public List<Reserve> Reserves { get; set; }

        [DataMember]
        public List<Purchase> Purchases { get; set; }

        public Stock()
        {
            this.Reserves = new List<Reserve>();
            this.Purchases = new List<Purchase>();
            this.KitChildrenSkuIds = new List<string>();
        }
        
    }

    

}
