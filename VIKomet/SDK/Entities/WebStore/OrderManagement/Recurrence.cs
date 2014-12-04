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
    public class Recurrence 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }
        /// <summary>
        /// SkuId do item que a linha representa, gerado no banco.
        /// </summary>
        [DataMember(Name = "InternalSkuId")]
        public string InternalSkuId { get; set; }

        /// <summary>
        /// Data de criação da recorrência.
        /// </summary>
        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "Lines")]
        public List<RecurrenceLine> Lines { get; set; }

        public Recurrence()
        {
            this.Lines = new List<RecurrenceLine>();
        }
    }
}
