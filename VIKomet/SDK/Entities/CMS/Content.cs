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
    public class Content  
    {
        [DataMember(Name = "Id")]
        public string ItemId { get; set; }

        [DataMember(Name = "AccountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Data")]
        public string Data { get; set; }

        [DataMember(Name = "CategoryID")]
        public string CategoryID { get; set; }

        [DataMember(Name = "StatusID")]
        public string StatusID { get; set; }

        [DataMember(Name = "Approved")]
        public bool Approved { get; set; }

        [DataMember(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "ApprovalDate")]
        public DateTime ApprovalDate { get; set; }

        [DataMember(Name = "CreatorID")]
        public string CreatorID { get; set; }

        [DataMember(Name = "ApproverID")]
        public string ApproverID { get; set; }

        [DataMember(Name = "Slug")]
        public string Slug { get; set; }


        [DataMember(Name = "Exclusive")]
        public bool Exclusive { get; set; }


        [DataMember(Name = "PageTitle")]
        public string PageTitle { get; set; }

        [DataMember(Name = "MetaDescription")]
        public string MetaDescription { get; set; }

        [DataMember(Name = "MetaKeywords")]
        public string MetaKeywords { get; set; }
         
        [DataMember(Name = "CanDelete")]
        public bool CanDelete { get; set; }

        [DataMember(Name = "ContentRendererFile")]
        public string ContentRendererFile { get; set; }
        
        
    }
}
