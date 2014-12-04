using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion.Effects
{
    public class CartPercentageDiscountEffect : Effect
    {
        public decimal DiscountValueInPercentage { get; private set; }

        public CartPercentageDiscountEffect(decimal discountValueInPercentage)
        {
            this.DiscountValueInPercentage = discountValueInPercentage;
        }

        public override PriceTag GetPriceTag(ShoppingCart cart)
        {
            PriceTag priceTag = new PriceTag();
            priceTag.Value = decimal.Multiply(DiscountValueInPercentage, cart.Total);
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
