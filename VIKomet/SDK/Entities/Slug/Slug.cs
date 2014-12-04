using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Slug
{

    [Serializable]
    [DataContract]
    public class Slug 
    { 
 
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "ObjectID")]
        public string ObjectID { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "SlugType")]
        public int SlugType { get; set; }

        [DataMember(Name = "SlugString")]
        public string SlugString { get; set; } 
    }
}
