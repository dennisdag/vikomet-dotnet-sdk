using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.Catalog
{
    [Serializable]
    [DataContract]
    public class Category 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "IDCategory")]
        public string IDCategory { get; set; }

        [DataMember(Name = "IDParentCategory")]
        public string IDParentCategory { get; set; }

        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Título")]
        public string Name { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; } 


    }
}
