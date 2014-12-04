using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.Settings
{

    [Serializable]
    [DataContract]
    public class Settings 
    {
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "AccountSecret")]
        public string AccountSecret { get; set; }

        [DataMember(Name = "SuperUserId")]
        public string SuperUserId { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Document")]
        public string Document { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "StoreDomain")]
        public string StoreDomain { get; set; }

        [DataMember(Name = "URLStorage")]
        public string URLStorage { get; set; }

        [DataMember(Name = "URLCDN")]
        public string URLCDN { get; set; }

        [DataMember(Name = "LogoURL")]
        public string LogoURL { get; set; }

        [DataMember(Name = "Blog")]
        public string Blog { get; set; }

        [DataMember(Name = "ContactEmail")]
        public string ContactEmail { get; set; }
     
        [DataMember(Name = "IDDefaultTemplate")]
        public string IDDefaultTemplate { get; set; }

        [DataMember(Name = "ApplicationName")]
        public string ApplicationName { get; set; }

        [DataMember(Name = "ApplicationVersion")]
        public string ApplicationVersion { get; set; }

        [DataMember(Name = "OpenToCustomers")]
        public bool OpenToCustomers { get; set; }

        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "IsBackofficeActive")]
        public bool IsBackofficeActive { get; set; }

        [DataMember(Name = "AllowOneClickBuy")]
        public bool AllowOneClickBuy { get; set; }

        [DataMember(Name = "AllowSubscriptions")]
        public bool AllowSubscriptions { get; set; }

        [DataMember(Name = "HasAntiFraud")]
        public bool HasAntiFraud { get; set; }

        [DataMember(Name = "DiscountLimit")]
        public decimal DiscountLimit { get; set; }

        //TODO: Temporario. Enquanto não o conceito de cd não estiver implementado.
        [DataMember(Name = "WarehousePostalCode")]
        public long WarehousePostalCode { get; set; }

        //TODO: Temporario. Enquanto não o conceito de cd não estiver implementado.
        [DataMember(Name = "ExpeditionTimeInDays")]
        public int ExpeditionTimeInDays { get; set; }


        [DataMember(Name = "OrderTrackingEmail")]
        public string OrderTrackingEmail { get; set; }

        [DataMember(Name = "NoReplyEmail")]
        public string NoReplyEmail { get; set; }


        [DataMember(Name = "SMTPHost")]
        public string SMTPHost { get; set; }

        [DataMember(Name = "SMTPPort")]
        public int SMTPPort { get; set; }

        [DataMember(Name = "SMTPUsername")]
        public string SMTPUsername { get; set; }

        [DataMember(Name = "SMTPPassword")]
        public string SMTPPassword { get; set; }

        [DataMember(Name = "SMTPRequireTLS")]
        public bool SMTPRequireTLS { get; set; }

        [DataMember(Name = "IsCMSEntryPoint")]
        public bool IsCMSEntryPoint { get; set; }

        [DataMember(Name = "CMSTemplate")]
        public string CMSTemplate { get; set; }

        [DataMember(Name = "SearchDistance")]
        public double SearchDistance { get; set; }

        [DataMember(Name = "BankAgency")]
        public string BankAgency { get; set; }

        [DataMember(Name = "CurrentAccount")]
        public string CurrentAccount { get; set; }

        [DataMember(Name = "MoipEnvironmentUrl")]
        public string MoipEnvironmentUrl { get; set; }

        [DataMember(Name = "MoipRecurrenceEnvironmentUrl")]
        public string MoipRecurrenceEnvironmentUrl { get; set; }

        [DataMember(Name = "MoipToken")]
        public string MoipToken { get; set; }

        [DataMember(Name = "MoipKey")]
        public string MoipKey { get; set; }

        [DataMember(Name = "MinimumOrderValue")]
        public decimal MinimumOrderValue { get; set; }

        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}
