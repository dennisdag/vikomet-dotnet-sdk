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
    public class Address  
    {
        [DataMember(Name = "Id")]
        public string AddressId { get; set; }

        [DataMember(Name = "MainAddress")]
        public bool MainAddress { get; set; }

        [DataMember(Name = "AddressType")]
        public int AddressType { get; set; }

        [DataMember(Name = "AddressAlias")]
        public string AddressAlias { get; set; }
        
        [DataMember(Name = "RecipientName")]
        public string RecipientName { get; set; }
        
        [DataMember(Name = "PostalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "AddressLine1")]
        public string AddressLine1{ get; set; }

        [DataMember(Name = "AddressLine2")]
        public string AddressLine2 { get; set; }
        
        [DataMember(Name = "Landmark")]
        public string Landmark{ get; set; }

        [DataMember(Name = "Neighborhood")]
        public string Neighborhood{ get; set; }

        [DataMember(Name = "City")]
        public string City{ get; set; }
        
        [DataMember(Name = "State")]
        public string State{ get; set; }
        
        [DataMember(Name = "IsBillingAddress")]
        public bool IsBillingAddress { get; set; }

        public void Validate()
        {
            //if (string.IsNullOrEmpty(this.AddressAlias))
            //{
            //    throw new ApplicationException("Favor preencher um apelido para este endereço");
            //}

            if (string.IsNullOrEmpty(this.AddressLine1))
            {
                throw new ApplicationException("Favor preencher o endereço");
            }

            if (string.IsNullOrEmpty(this.AddressLine2))
            {
                throw new ApplicationException("Favor preencher o complemento do endereço");
            }

            //if (string.IsNullOrEmpty(this.Landmark))
            //{
            //    throw new ApplicationException("Favor preencher o ponto de referência de seu endereço");
            //}

            if (string.IsNullOrEmpty(this.PostalCode))
            {
                throw new ApplicationException("Favor preencher o CEP de seu endereço");
            }

            if (string.IsNullOrEmpty(this.Neighborhood))
            {
                throw new ApplicationException("Favor preencher o seu bairro");
            }

            if (string.IsNullOrEmpty(this.City))
            {
                throw new ApplicationException("Favor preencher a sua cidade");
            }

            if (string.IsNullOrEmpty(this.State))
            {
                throw new ApplicationException("Favor preencher o seu estado");
            }
             

            if (this.AddressType != 0 && this.AddressType != 1)
            {
                throw new ApplicationException("Tipo de endereço inválido");
            }
        }
    }

}
