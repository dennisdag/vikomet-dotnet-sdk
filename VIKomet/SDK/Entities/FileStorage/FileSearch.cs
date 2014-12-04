 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace VIKomet.SDK.Entities.FileStorage
{
    [Serializable]
    [DataContract(Name = "FileSearch")] 
    public class FileSearch 
    {
        public string Id { get; set; }

        /// <summary>
        /// File Identifier.
        /// </summary>
        [DataMember(Name = "IDFileKey")]
        public string IDFileKey
        {   //Propriedade criada para o Id da heranca ficar no mesmo nivel no json
            get
            { return Id; }
            set
            {
                Id = value;
            }
            //So mantem o Set, pq senao nao serializa para todos os tipos
        }

        /// <summary>
        /// File's Privacy.
        /// </summary>
        public bool IsPrivate
        {
            get
            {
                return (UsersCanGET == null || UsersCanGET.Count == 0);
            }
        }

        /// <summary>
        /// Storage Resource Identifier.
        /// </summary>
        [DataMember(Name = "ResourceIdentifier")]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Instance Identifier.
        /// </summary>
        [DataMember(Name = "AccountId")]  //Para o commerce, um accountId = accountId
        public string AccountId { get; set; }

        /// <summary>
        /// File Name.
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Field used to order the search results by Name.
        /// </summary>
        [DataMember(Name = "NameSort", EmitDefaultValue = false)]
        public string NameSort { get; set; }

        /// <summary>
        /// File Description.
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }
         
        /// <summary>
        /// Item's Extended Properties
        /// </summary>
        [DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
        public Dictionary<string, object> ExtendedProperties { get; set; }
         
        /// <summary>
        /// Date of creation.
        /// </summary> 
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Item's Last Update date.
        /// </summary>
        [DataMember(Name = "LastUpdate", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

        [DataMember(Name = "UsersCanGET")]
        public List<string> UsersCanGET { get; set; }

        /// <summary>
        /// File's ContentType update.
        /// </summary>
        [DataMember(Name = "ContentType")]
        public string ContentType { get; set; }
         
    }
}
