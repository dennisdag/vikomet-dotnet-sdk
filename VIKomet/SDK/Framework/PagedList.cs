using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Framework
{
    [DataContract(Name="PagedList")]
    public class PagedList<T>
    {
        public PagedList()
        {
        }

        public PagedList(IEnumerable<T> items)
        {
            Items = items.ToList<T>();
        }

        [DataMember(Name = "Items")]
        public List<T> Items { get; set; }


        [DataMember(Name = "CurrentPage")]
        public int CurrentPage { get; set; }
        [DataMember(Name = "TotalPages")]
        public long TotalPages { get
        {
            if (ItemsPerPage == 0) return 0;

            var i = TotalItemCount/ItemsPerPage;
            if ((ItemsPerPage*i) < TotalItemCount) {
                i++;
            }
            return i;
        }
            set
            {
            }
        }
        [DataMember(Name = "ItemsPerPage")]
        public int ItemsPerPage { get; set; }
        [DataMember(Name = "TotalItemCount")]
        public long TotalItemCount { get; set; }

    }
}
