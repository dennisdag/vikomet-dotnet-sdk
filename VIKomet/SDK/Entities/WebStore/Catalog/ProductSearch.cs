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
    [DataContract(Name = "ProductSearch")]
 
    public class ProductSearch 
    {
        public string Id { get; set; }

        [DataMember(Name = "IDProductKey")]
        public string IDProductKey { get; set; }

        [DataMember(Name = "IDProduct")]
        public string IDProduct { get; set; }

        [DataMember(Name = "IDParentProductKey")]
        public string IDParentProductKey { get; set; }
         
        [DataMember(Name = "IDRootProductKey")]
        public string IDRootProductKey { get; set; }
        
        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")] 
        public string Name { get; set; }

        [DataMember(Name = "InheritedName")]
        [Display(Name = "InheritedName")] 
        public string InheritedName { get; set; }

        [DataMember(Name = "InheritedNameSort")]
        public string InheritedNameSort { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Brand")]
        public string Brand { get; set; }

        [DataMember(Name = "IDBrand")]
        public string IDBrand { get; set; }

        [DataMember(Name = "Category")]
        public string Category { get; set; }

        [DataMember(Name = "IDCategory")]
        public string IDCategory { get; set; }


        [DataMember(Name = "PriceWas")]
        public decimal PriceWas { get; set; }

        [DataMember(Name = "PriceNow")] 
        public decimal PriceNow { get; set; }

        [DataMember(Name = "PriceNowSort")]
        public decimal PriceNowSort { get; set; }

        [DataMember(Name = "SellStartDate")]
        public DateTime SellStartDate { get; set; }

        [DataMember(Name = "SellEndDate")]
        public DateTime SellEndDate { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "Image")]
        public Image Image { get; set; }

        [DataMember(Name = "Video")]
        public Video Video { get; set; }

        [DataMember(Name = "Searchable")]
        public bool Searchable { get; set; }

        [DataMember(Name = "Sellable")]
        public bool Sellable { get; set; }

        [DataMember(Name = "ProductType")]
        public int ProductType { get; set; }

        [DataMember(Name = "AllowRecurrentSell")]
        public bool AllowRecurrentSell { get; set; }

        [DataMember(Name = "AvailableStock")]
        public int AvailableStock { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

        [DataMember(Name = "ProductOwner")]
        public string ProductOwner { get; set; }

        [DataMember(Name = "Location")]
        public Location Location { get; set; }

        [DataMember(Name = "Distance")]
        public double? Distance { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

        [DataMember(Name = "SellerId")]
        public string SellerId { get; set; }

    }
}
