using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLangBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            AClass a;
            a = null;
            AClass b = new AClass();
            var hashCode = b.GetHashCode();
            var equal = b.Equals(null);
            //Default funciton generated GetHashCode
            //Equals, ToString(),GetType()
            bool ret = b == a;
        }
    }
}
