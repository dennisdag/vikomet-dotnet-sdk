using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace VIKomet.SDK.Entities.Common
{

    [Serializable]
    [DataContract]
    public class Video
    {
        [DataMember(Name = "URL")]
        public string URL { get; set; }
    }
}