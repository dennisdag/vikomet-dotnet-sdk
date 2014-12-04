 
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
    public class Brand 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; } 

        [DataMember(Name = "IDBrand")]
        public string IDBrand { get; set; } 

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
