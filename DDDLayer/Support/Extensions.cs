using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDLayer.Support
{
    public static class Extensions
    {
        public static bool IsDefined (this object obj)
        {
            return obj != null;
        }

        public static bool IsDefined(this string obj)
        {
            return !string.IsNullOrEmpty(obj);
        }
    }
}
