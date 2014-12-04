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
    [DataContract]
    public class File :  ICloneable
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

            if (this.ExtendedProperties.ContainsKey(key) == false)
            {
                return null;
            }

            return this.ExtendedProperties[key];
        }


        /// <summary>
        /// File Identifier.
        /// </summary>
        [DataMember(Name = "FileId")]
        public string FileId { get; set; }


        /// <summary>
        /// Storage Resource Identifier.
        /// </summary>
        [DataMember(Name = "ResourceIdentifier")]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// File Name.
        /// </summary>
        [DataMember(Name = "Name")]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Instance Identifier.
        /// </summary>
        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }
         
        /// <summary>
        /// File's Description.
        /// </summary>
        [DataMember(Name = "Description")]
        public string Description { get; set; }

      

        /// <summary>
        /// File's Extended Properties.
        /// </summary>
        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

        /// <summary>
        /// File's Privacy.
        /// </summary>
        public bool IsPrivate
        {
            get
            {
                return (UsersCanGET != null && UsersCanGET.Count > 0);
            }
        }

        /// <summary>
        /// File's Owner Identifier.
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

        /// <summary>
        /// Date of creation.
        /// </summary> 
        [DataMember(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }


        /// <summary>
        /// File's date of last update.
        /// </summary>
        [DataMember(Name = "LastUpdate")]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// File's ContentType.
        /// </summary>
        [DataMember(Name = "ContentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// File's Private Access Url.
        /// </summary>
        [DataMember(Name = "PrivateAccessUrl")]
        public string PrivateAccessUrl { get; set; }

        
    }
}


