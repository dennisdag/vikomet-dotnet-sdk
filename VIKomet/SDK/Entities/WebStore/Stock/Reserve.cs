using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Stock
{
    /// <summary>
    /// Entidade que representa a reseva de um sku. 
    /// </summary>
    [Serializable]
    [DataContract]
    public class Reserve
    {
        /// <summary>
        /// Id da reserva no banco.
        /// </summary>
        [DataMember]
        virtual public string ReserveId { get; set; }

        /// <summary>
        /// Quantidade reservada.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }

        /// <summary>
        /// Data de criação da reserva.
        /// </summary>
        [DataMember]
        public DateTime ReserveDate { get; set; }
        
        /// <summary>
        /// Data de expiração da reserva. Reservas de pedidos não finalizados devem ser expiradas.
        /// </summary>
        [DataMember]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Id do estoque a que a reserva pertence.
        /// </summary>
        [DataMember]
        public string InventoryId { get; set; }

        /// <summary>
        /// Id da reserva pai da reserva em questão (deve ser preenchido para reservas de skus que são filhos de kits).
        /// </summary>
        [DataMember]
        public string ParentReserveId { get; set; }

        /// <summary>
        /// Ids das reservas filhas da reserva em questão (deve ser preenchido para reservas de skus que são kits).
        /// </summary>
        [DataMember]
        public List<ChildReserveData> ChildrenReserveData { get; set; }

        public Reserve()
        {
            this.ChildrenReserveData = new List<ChildReserveData>();
        }

    }

    [Serializable]
    [DataContract]
    public class ChildReserveData
    {
        [DataMember]
        public string InventoryId { get; set; }

        [DataMember]
        public string ReserveId { get; set; }

        public ChildReserveData(string inventoryId, string reserveId)
        {
            this.InventoryId = inventoryId;
            this.ReserveId = reserveId;
        }
    }
}
