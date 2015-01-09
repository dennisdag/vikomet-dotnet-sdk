using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class ReadableStringAttribute : Attribute
    {
        private string str;
        //private string culture;

        public string ReadableString
        {
            get { return str; }
        }


        public ReadableStringAttribute(string str)
        {
            this.str = str;
        }

        //public ReadableStringAttribute(string str, string culture)
        //{
        //    this.str = str;
        //    this.culture = culture;
        //}
    }

}
