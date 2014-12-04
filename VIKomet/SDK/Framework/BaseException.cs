using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.SDK.Framework
{
    public class BaseException : Exception
    {
        public int Code { get; set; }

        public BaseException(string message, int code) : base(message)
        {
            this.Code = code;
        }
        public BaseException()
        {
        }
        public Error ToError()
        {

            return new Error()
            {
                Code = 100,
                ExceptionMessage = this.Message,
                Type = this.GetType().ToString()
            };
        }
    }
}
