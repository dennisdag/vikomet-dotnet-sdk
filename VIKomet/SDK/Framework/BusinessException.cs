using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Framework
{
    public class BusinessException : BaseException
    {
        public BusinessException(string message, int code)
            : base(message, code)
        {

        }

    }
}
