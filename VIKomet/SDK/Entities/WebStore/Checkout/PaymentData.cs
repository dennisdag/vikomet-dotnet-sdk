using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.PaymentGateway;

namespace VIKomet.SDK.Entities.WebStore.Checkout
{
    public class PaymentData
    {
        public PaymentMethod PaymentMethod { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
