using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    public class IntegrationException : BaseException
    {
        public IntegrationException(VIErrors error)
            : this(error.ToReadableString(), (int)error)
        {
        }
        public IntegrationException(string message, int code)
            : base(message, code)
        {

        }
    }
}
