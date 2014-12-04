using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using VIKomet.SDK.Entities.Common; 

namespace VIKomet.SDK.Entities.Catalog
{

    [Serializable]
    [DataContract]
    public class Product : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object GetExtendedProperty(string key)
        {
            if ((this.ExtendedProperties == null) || (this.ExtendedProperties.Count == 0))
            {
                return null;
            }

            if (this.ExtendedProperties.ContainsKey(key) == false) {
                return null;
            }

            return this.ExtendedProperties[key];
        }

        [DataMember(Name = "ProductId")]
        public string ProductId { get; set; }

        [DataMember(Name = "IDProduct")]
        public string IDProduct { get; set; }

        [DataMember(Name = "IDParentProduct")]
        public string IDParentProduct { get; set; }

        [DataMember(Name = "IDRootProduct")]
        public string IDRootProduct { get; set; }

        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "InheritedName")]
        [Display(Name = "InheritedName")]
        public string InheritedName { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "SellStartDate")]
        public DateTime SellStartDate { get; set; }
        [DataMember(Name = "SellEndDate")]
        public DateTime SellEndDate { get; set; }


        /// <summary>
        /// Just for knockout binding
        /// </summary>
        [DataMember(Name = "SellStartDateStr")]
        public string SellStartDateStr
        {
            get
            {
                if (SellStartDate == DateTime.MinValue)
                {
                    SellStartDate = DateTime.Now;
                }
                return SellStartDate.ToString("d");
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    SellStartDate = DateTime.Now;
                }
                else
                {
                    SellStartDate = DateTime.Parse(value);
                }
            }
        }

        /// <summary>
        /// Just for knockout binding
        /// </summary>
        [DataMember(Name = "SellEndDateStr")]
        public string SellEndDateStr
        {
            get
            {
                if (SellEndDate == DateTime.MinValue || SellEndDate == DateTime.MaxValue)
                {
                    return "";
                }
                return SellEndDate.ToString("d");
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    SellEndDate = DateTime.MaxValue;
                }
                else
                {
                    SellEndDate = DateTime.Parse(value);
                }
            }
        }

        [DataMember(Name = "Category")]
        public string Category { get; set; }

        [DataMember(Name = "IDCategory")]
        public string IDCategory { get; set; }

        [DataMember(Name = "Brand")]
        public string Brand { get; set; }

        [DataMember(Name = "IDBrand")]
        public string IDBrand { get; set; }

        [DataMember(Name = "PriceWas")]
        public decimal PriceWas { get; set; }

        [DataMember(Name = "PriceNow")]
        public decimal PriceNow { get; set; }

        [DataMember(Name = "AvailableStock")]
        public int AvailableStock { get; set; }

        [DataMember(Name = "ImagesToErase")]
        public List<Image> ImagesToErase { get; set; }

        [DataMember(Name = "Images")]
        public List<Image> Images { get; set; }

        [DataMember(Name = "Videos")]
        public List<Video> Videos { get; set; }

        /// <summary>
        /// Comprimento em centímetros.
        /// </summary>
        [DataMember(Name = "Length")]
        public decimal Length { get; set; }

        /// <summary>
        /// Largura em centímetros.
        /// </summary>
        [DataMember(Name = "Width")]
        public decimal Width { get; set; }

        /// <summary>
        /// Altura em centímetros.
        /// </summary>
        [DataMember(Name = "Height")]
        public decimal Height { get; set; }

        /// <summary>
        /// Peso em gramas.
        /// </summary>
        [DataMember(Name = "Weight")]
        public decimal Weight { get; set; }

        [DataMember(Name = "MinimumStock")]
        public int MinimumStock { get; set; }

        [DataMember(Name = "EAN")]
        public string EAN { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "Products")]
        public List<VIKomet.SDK.Entities.Catalog.Product> Products { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "MetaDescription")]
        public string MetaDescription { get; set; }

        [DataMember(Name = "MetaKeywords")]
        public string MetaKeywords { get; set; }

        [DataMember(Name = "Searchable")]
        public bool Searchable { get; set; }

        [DataMember(Name = "Sellable")]
        public bool Sellable { get; set; }

        [DataMember(Name = "SellableSystem")]
        public bool SellableSystem { get; set; }

        [DataMember(Name = "IsVirtual")]
        public bool IsVirtual { get; set; }

        [DataMember(Name = "AllowRecurrentSell")]
        public bool AllowRecurrentSell { get; set; }

        [DataMember(Name = "ProductType")]
        public int ProductType { get; set; }

        [DataMember(Name = "AllowedPeriodicityInDays")]
        public List<string> AllowedPeriodicityInDays { get; set; }

        [DataMember(Name = "SellerId")]
        public string SellerId { get; set; }

        //[DataMember(Name = "PageTemplate")]
        //public bool PageTemplate { get; set; }

        //[DataMember(Name = "Categorias")]
        //public List<string> Categorias { get; set; }

        //[DataMember(Name = "Lojas")]
        //public List<string> Lojas { get; set; }

        //[DataMember(Name = "Acessorios")]
        //public List<string> Acessorios { get; set; }

        //[DataMember(Name = "Sugestoes")]
        //public List<string> Sugestoes { get; set; }

        //[DataMember(Name = "Similar")]
        //public List<string> Similar { get; set; }

        //[DataMember(Name = "Colecoes")]
        //public List<string> Colecoes { get; set; }

        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; } 
        
        [DataMember(Name = "ProductOwner")]
        public string ProductOwner { get; set; }

        [DataMember(Name = "Location")]
        public Location Location { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }


    }
}
