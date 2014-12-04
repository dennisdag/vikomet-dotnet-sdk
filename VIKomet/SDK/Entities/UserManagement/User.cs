using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.UserManagement
{

    [Serializable]
    [DataContract]
    public class User 
    {
        [DataMember(Name = "Id")]
        public string UserId { get; set; }

        
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "OneClickBuyActive")]
        public bool OneClickBuyActive { get; set; }

        [DataMember(Name = "Username")]
        public string Username { get; set; }

        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                var u1 = "";
                var u2 = "";

                u1 = (string.IsNullOrEmpty(this.FirstName) ? "" : this.FirstName);
                u2 = (string.IsNullOrEmpty(this.LastName) ? "" : this.LastName);

                return u1 + " " + u2;
            }
        }

        [DataMember(Name = "DocumentNumber")]
        public string DocumentNumber { get; set; }

        [DataMember(Name = "DocumentNumber2")]
        public string DocumentNumber2 { get; set; }

        [DataMember(Name = "PhoneNumber1")]
        public string PhoneNumber1 { get; set; }

        [DataMember(Name = "PhoneNumber2")]
        public string PhoneNumber2 { get; set; }

        [DataMember(Name = "MobilePhone")]
        public string MobilePhone { get; set; }

        [DataMember(Name = "Newsletter")]
        public bool Newsletter { get; set; }

        [DataMember(Name = "NewsletterSMS")]
        public bool NewsletterSMS { get; set; }

        [DataMember(Name = "Gender")]
        public string Gender { get; set; }
        
        [DataMember(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [DataMember(Name = "FormattedBirthdate")]
        public string FormattedBirthdate
        {

            get
            {
                return (Birthdate == null) ? null : Birthdate.ToString("dd/MM/yyyy");
            }
            set
            {
                
            }
        }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "PasswordSalt")]
        public string PasswordSalt { get; set; }

        [DataMember(Name = "IsConfirmed")]
        public bool IsConfirmed { get; set; }

        [DataMember(Name = "ConfirmationToken")]
        public string ConfirmationToken { get; set; }

        [DataMember(Name = "Createdate")]
        public DateTime Createdate { get; set; }

        [DataMember(Name = "PasswordChangedDate")]
        public DateTime PasswordChangedDate { get; set; }

        [DataMember(Name = "PasswordFailuresSinceLastSuccess")]
        public int PasswordFailuresSinceLastSuccess { get; set; } 

        [DataMember(Name = "Addresses")]
        public List<Address> Addresses { get; set; }

        [DataMember(Name = "Permissions")]
        public List<string> Permissions { get; set; }

        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

        [DataMember(Name = "UserType")]
        public string UserType { get; set; }

        public User()
        { 
        }
    }
}