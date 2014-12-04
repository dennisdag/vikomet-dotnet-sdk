using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion.Causes
{
    [Serializable]
    [DataContract]
    public class CartHasSkuCause : Cause
    {
        [DataMember(Name = "SkuId")]
        public string SkuId { get; private set; }

        public CartHasSkuCause(string skuId)
        {
            this.SkuId = skuId;
        }

        public bool Match(ShoppingCart cart)
        {
            return cart.Lines.Find(line => line.InternalSkuId.Equals(SkuId)) != null;
        }

    }
}
