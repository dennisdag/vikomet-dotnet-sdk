using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.Catalog
{
    [Serializable]
    [DataContract]
    public class Location
    {
        [DataMember(Name = "Lat")]
        public double Lat { get; set; }

        [DataMember(Name = "Lon")]
        public double Lon { get; set; }
    }
}
