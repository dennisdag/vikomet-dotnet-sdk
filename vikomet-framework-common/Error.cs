using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    [DataContract]
    [Serializable]
    public class Error
    {
        [DataMember()]
        public string ExceptionMessage { get; set; }
        [DataMember()]
        public string Type { get; set; }
        [DataMember()]
        public int Code { get; set; }
    }
}
