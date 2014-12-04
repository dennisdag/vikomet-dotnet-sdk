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
    public class Promotion  
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }
         
        public string AccountId { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }
        public List<Cause> Causes { get; set; }
        public List<Effect> Effects { get; set; }
        
        public bool Cumulative { get; set; }

        [DataMember(Name = "Active")]
        public bool Active { get; set; }

        [DataMember(Name = "Begin")]
        public DateTime Begin { get; set; }

        [DataMember(Name = "End")]
        public DateTime End { get; set; }

        [DataMember(Name = "Status")]
        public string Status
        {
            get
            {
                if (DateTime.Now > Begin && DateTime.Now < End)
                {
                    return "Vigente";
                }
                else
                {
                    return "Expirada";
                }
            }

            private set {}
        }

        public Promotion()
        {
            this.Causes = new List<Cause>();
            this.Effects = new List<Effect>();
        }

        public bool Match(ShoppingCart cart)
        {
            foreach (Cause cause in Causes)
            {
                if (!cause.Match(cart))
                    return false;
            }
            return true;
        }

        public void Apply(ShoppingCart cart)
        {

            foreach (Effect effect in Effects)
            {
                effect.Apply(cart, this.Name);
            }

            // armazena no carrinho a promoção aplicada
            cart.Promotions.Add(this);
        }

        public decimal Total(ShoppingCart cart)
        {
            decimal discountValue = decimal.Zero;

            foreach (Effect effect in Effects)
            {
                PriceTag priceTag = effect.GetPriceTag(cart);
                discountValue = decimal.Add(discountValue, priceTag.Value);
            }
            
            return discountValue;
        }

    }
}
