using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion.Effects
{
    public class CartNominalDiscountEffect : Effect
    {
        public decimal NominalDiscountValue { get; private set; }

        public CartNominalDiscountEffect(decimal discountValue)
        {
            this.NominalDiscountValue = discountValue;
        }

        public override PriceTag GetPriceTag(ShoppingCart cart)
        {
            PriceTag priceTag = new PriceTag();
            priceTag.Value = NominalDiscountValue;
            return priceTag;
        }

        public override void Apply(ShoppingCart cart, string promotionName)
        {
            PriceTag priceTag = GetPriceTag(cart);
            priceTag.Source = promotionName;
            cart.PriceTags.Add(priceTag);
        }

    }
}
