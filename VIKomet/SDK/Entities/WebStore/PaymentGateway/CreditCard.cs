using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.PaymentGateway
{

    [Serializable]
    [DataContract]
    public class CreditCard  
    {
        [DataMember(Name = "BankingCompany")]
        public string BankingCompany { get; set; }

        [DataMember(Name = "Installments")]
        public int Installments { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "CardNumber")]
        public string CardNumber { get; set; }

        [DataMember(Name = "CVV")]
        public string CVV { get; set; }

        [DataMember(Name = "ExpirationMonth")]
        public short ExpirationMonth { get; set; }

        [DataMember(Name = "ExpirationYear")]
        public short ExpirationYear { get; set; }
    }
}