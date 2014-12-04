using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion
{

    [Serializable]
    [DataContract]
    public abstract class Effect
    {
        protected readonly string LINE_NOT_FOUND_ERROR_MESSAGE = "Expected line for sku {0} not found.";
        
        public abstract PriceTag GetPriceTag(ShoppingCart cart);

        public abstract void Apply(ShoppingCart cart, string promotionName);
        
    }
}
