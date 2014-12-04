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
    [DataContract]
    public class Item  
    {
        
        public object GetExtendedProperty(string key)
        {
            if ((this.ExtendedProperties == null) || (this.ExtendedProperties.Count == 0))
            {
                return null;
            }

            if (this.ExtendedProperties.ContainsKey(key) == false)
            {
                return null;
            }

            return this.ExtendedProperties[key];
        }

        [DataMember(Name = "ItemId")]
        public string ItemId { get; set; }

        [DataMember(Name = "IDItem")]
        public string IDItem { get; set; }

        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "ItemType")]
        public string ItemType { get; set; }

        [DataMember(Name = "ItemTypeId")]
        public string ItemTypeId { get; set; }

        [DataMember(Name = "ImagesToErase")]
        public List<Image> ImagesToErase { get; set; }

        [DataMember(Name = "Images")]
        public List<Image> Images { get; set; }

        [DataMember(Name = "Videos")]
        public List<Video> Videos { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "Searchable")]
        public bool Searchable { get; set; }

        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }


        [DataMember(Name = "Location")]
        public Location Location { get; set; }

        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }


        /// <summary>
        /// Item's Owner Identifier.
        /// </summary>
        [DataMember(Name = "Owner")]
        public string Owner { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can GET.
        /// </summary>
        [DataMember(Name = "UsersCanGET")]
        public List<string> UsersCanGET { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can CREATE.
        /// </summary>
        [DataMember(Name = "UsersCanPOST")]
        public List<string> UsersCanPOST { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can UPDATE.
        /// </summary>
        [DataMember(Name = "UsersCanPUT")]
        public List<string> UsersCanPUT { get; set; }

        /// <summary>
        /// User Permissions. List of Users that can DELETE.
        /// </summary>
        [DataMember(Name = "UsersCanDELETE")]
        public List<string> UsersCanDELETE { get; set; }

    }
}
