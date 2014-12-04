using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using VIKomet.SDK.Entities.Common;


namespace VIKomet.SDK.Entities.Datastorage
{
    [Serializable]
    [DataContract(Name = "ItemSearch")]

    public class ItemSearch
    {
        public string Id { get; set; }

        [DataMember(Name = "IDItemKey")]
        public string IDItemKey
        {   //Propriedade criada para o Id da heranca ficar no mesmo nivel no json
            get
            { return Id; }
            set
            {
                Id = value;
            }
            //So mantem o Set, pq senao nao serializa para todos os tipos
        }


        [DataMember(Name = "AccountId")]  //Para o commerce, um accountId = accountId
        public string AccountId { get; set; }

        [DataMember(Name = "IDItem")]
        public string IDItem { get; set; }

        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [DataMember(Name = "NameSort")]
        public string NameSort { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "Image")]
        public Image Image { get; set; }

        [DataMember(Name = "Video")]
        public Video Video { get; set; }

        [DataMember(Name = "Searchable")]
        public bool Searchable { get; set; }

        [DataMember(Name = "ItemType")]
        public string ItemType { get; set; }


        [DataMember(Name = "ItemTypeId")]
        public string ItemTypeId { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

   
        [DataMember(Name = "Location")]
        public Location Location { get; set; }

        [DataMember(Name = "Distance")]
        public double? Distance { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

        [DataMember(Name = "Createdate")]
        public DateTime Createdate { get; set; }
        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

    }
}
