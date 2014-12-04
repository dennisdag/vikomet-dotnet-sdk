using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.CMS
{

    [Serializable]
    [DataContract]
    public class Category 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "CategoryID")]
        public string CategoryID { get; set; }

        [DataMember(Name = "ParentCategoryID")]
        public string ParentCategoryID { get; set; }

        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "CanDelete")]
        public bool CanDelete { get; set; }

        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}
