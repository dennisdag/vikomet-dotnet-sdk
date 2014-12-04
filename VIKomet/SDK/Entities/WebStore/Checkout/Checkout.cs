using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKomet.SDK.Entities.UserManagement;
using VIKomet.SDK.Entities.PaymentGateway;

namespace VIKomet.SDK.Entities.WebStore.Checkout
{
    public class Checkout
    {
        public string CartId { get; set; }
        public User User{ get; set; }
        public string AnonymousEmailAddress { get; set; }
        public Address ShippingAddress{ get; set; }
        public Address BillingAddress { get; set; }
        public bool ReturningCustomer { get; set; }
        public PaymentData PaymentData { get; set; }
        public int CheckoutType { get; set; }
        public AntiFraud AntiFraud { get; set; }
    }
}
