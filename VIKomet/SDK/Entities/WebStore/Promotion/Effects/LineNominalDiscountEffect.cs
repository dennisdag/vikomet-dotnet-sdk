using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion.Effects
{
    public class LineNominalDiscountEffect : Effect
    {

        public string InternalSkuId { get; private set; }
        public decimal NominalDiscountValue { get; private set; }

        public LineNominalDiscountEffect(string internalSkuId, decimal discountValue)
        {
            this.InternalSkuId = internalSkuId;
            this.NominalDiscountValue = discountValue;
        }
        
        public override OrderManagement.PriceTag GetPriceTag(OrderManagement.ShoppingCart cart)
        {
            PriceTag priceTag = new PriceTag();
            priceTag.Value = NominalDiscountValue;
            return priceTag;
        }

        public override void Apply(OrderManagement.ShoppingCart cart, string promotionName)
        {
            ShoppingCartLine line = cart.Lines.Find(l => l.InternalSkuId.Equals(InternalSkuId));
            if (line != null)
            {
                PriceTag priceTag = GetPriceTag(cart);
                priceTag.Source = promotionName;
                line.PriceTags.Add(priceTag);
            }
            else
            {
                throw new ApplicationException(string.Format(LINE_NOT_FOUND_ERROR_MESSAGE, InternalSkuId));
            }
        }
    }
}
