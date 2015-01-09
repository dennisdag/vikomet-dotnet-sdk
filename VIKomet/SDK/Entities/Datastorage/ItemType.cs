using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.Datastorage
{

    [Serializable]
    [DataContract]
    public class ItemType
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }
         
        [DataMember(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [DataMember(Name = "AccountId")]  //Para o commerce, um accountId = accountId
        public string AccountId { get; set; }
         
        [DataMember(Name = "Createdate")]
        public DateTime Createdate { get; set; }
         
        [DataMember(Name = "Updateddate")]
        public DateTime Updateddate { get; set; }

  
    }
}
