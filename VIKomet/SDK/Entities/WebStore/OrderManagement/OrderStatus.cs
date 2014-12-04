using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Entities.OrderManagement
{
    public enum OrderStatus
    {
        RECEIVED = 0,
        NOT_SHIPPED_YET = 1,
        SHIPPED = 2,
        CANCELLED = 3,
        ERROR = 4,
        DELIVERED = 5
    }
}
