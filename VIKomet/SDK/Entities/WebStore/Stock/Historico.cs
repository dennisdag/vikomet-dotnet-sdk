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
    public class Historico 
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "UserId")]
        public string UserId { get; set; }

        [DataMember(Name = "SkuId")]
        public string SkuId { get; set; }

        [DataMember(Name = "Operation")]
        public Operacao Operation { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "OperationDate")]
        public DateTime OperationDate { get; set; }

    }

    public enum Operacao
    {
        INC_STOCK, DEC_STOCK, RESERVE, CANCEL_RESERVE, PURCHASE, CANCEL_PURCHASE, CREATE_SALESCHANNEL, CANCEL_SALESCHANNEL
    }
}
