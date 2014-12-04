using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{

    public class PermissionDeniedException : BaseException
    {
        public PermissionDeniedException(string message, int code)
            : base(message, code)
        {

        }

        public PermissionDeniedException() : base("PermissionDeniedException", 401)
        {
        }
    }
}
