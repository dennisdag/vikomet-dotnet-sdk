using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.OrderManagement;

namespace VIKomet.SDK.Entities.Promotion.Effects
{
    public class LinePercentageDiscountEffect : Effect
    {

        public string InternalSkuId { get; private set; }
        public decimal DiscountValueInPercentage { get; private set; }

        public LinePercentageDiscountEffect(string internalSkuId, decimal discountValue)
        {
            this.InternalSkuId = internalSkuId;
            this.DiscountValueInPercentage = discountValue;
        }
        
        public override OrderManagement.PriceTag GetPriceTag(OrderManagement.ShoppingCart cart)
        {
            PriceTag priceTag = new PriceTag();

            ShoppingCartLine line = cart.Lines.Find(l => l.InternalSkuId.Equals(InternalSkuId));
            if (line != null)
            {
                priceTag.Value = decimal.Multiply(DiscountValueInPercentage, line.Total);
            }
            else
            {
                throw new ApplicationException(string.Format(LINE_NOT_FOUND_ERROR_MESSAGE, InternalSkuId));
            }
            
            return priceTag;
        }

        public override void Apply(OrderManagement.ShoppingCart cart, string promotionName)
        {
            ShoppingCartLine line = cart.Lines.Find(l => l.InternalSkuId.Equals(InternalSkuId));
            if(line != null)
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
