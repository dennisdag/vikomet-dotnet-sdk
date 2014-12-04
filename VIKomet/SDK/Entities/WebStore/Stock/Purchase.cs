using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace VIKomet.SDK.Entities.Stock
{
    [Serializable]
    [DataContract]
    public class Purchase
    {
        [DataMember]
        public string PurchaseId { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public string SalesChannelId { get; set; }

        [DataMember]
        public DateTime PurchaseDate { get; set; }

        [DataMember]
        public string InventoryId { get; set; }

        /// <summary>
        /// Id da compra pai da compra em questão (deve ser preenchido para compras de skus que são filhos de kits).
        /// </summary>
        [DataMember]
        public string ParentPurchaseId { get; set; }

        /// <summary>
        /// Ids das compras filhas da compra em questão (deve ser preenchido para compras de skus que são kits).
        /// </summary>
        [DataMember]
        public List<ChildPurchaseData> ChildrenPurchaseData { get; set; }

        public Purchase()
        {
            this.ChildrenPurchaseData = new List<ChildPurchaseData>();
        }

        [Serializable]
        [DataContract]
        public class ChildPurchaseData
        {
            [DataMember]
            public string InventoryId { get; set; }

            [DataMember]
            public string PurchaseId { get; set; }

            public ChildPurchaseData(string inventoryId, string purchaseId)
            {
                this.InventoryId = inventoryId;
                this.PurchaseId = purchaseId;
            }
        }

    }
}
