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
    public class CartTotalCause : Cause
    {
        [DataMember(Name = "CartTotal")]
        public decimal CartTotal { get; private set; }

        public CartTotalCause(decimal cartTotal)
        {
            this.CartTotal = cartTotal;
        }

        public bool Match(ShoppingCart cart)
        {
            return cart.Total > CartTotal;
        }

    }
}
