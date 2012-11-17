using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    //internal protected
    internal class ProtectedClass :  AbstractClass // AbstractPublicInternalClass // AbstractPublicClass //AbstractPublicInternalClass
    {

        protected override void SomeAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }

}
