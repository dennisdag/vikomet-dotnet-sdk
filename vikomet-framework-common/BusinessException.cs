using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    public class BusinessException : BaseException
    {
        public BusinessException(VIErrors error)
            : this(error.ToReadableString(), (int)error)
        {
        }
        public BusinessException(string message, int code)
            : base(message, code)
        {

        }


    }
}
