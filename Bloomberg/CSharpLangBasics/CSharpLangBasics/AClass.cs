using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLangBasics
{

    class AClass : IEquatable<AClass>
    {
        public bool Equals(AClass other)
        {
            //This is a subtle inifiteloop. because it is calling this equals which is itself
            return other.Equals(this);

        }
    }
}
