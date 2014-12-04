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
    public class Menu 
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "Order")]
        public string Order { get; set; }

        [DataMember(Name = "ParentMenuID")]
        public string ParentMenuID { get; set; }

        [DataMember(Name = "Name")] 
        public string Name { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Link")]
        public string Link { get; set; }

        [DataMember(Name = "CanDelete")]
        public bool CanDelete { get; set; }

        [DataMember(Name = "Items")]
        public List<Menu> Items { get; set; }

        [DataMember(Name = "MainMenu")]
        public bool MainMenu { get; set; }

        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "Approved")]
        public bool Approved { get; set; }

    }
}
