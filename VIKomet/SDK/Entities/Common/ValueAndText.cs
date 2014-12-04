using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Common
{
    [Serializable]
    [DataContract]
    public class ValueAndText
    {
        [DataMember(Name = "value")]
        public string value { get; set; }

        [DataMember(Name = "text")]
        public string text { get; set; }

    }
}
