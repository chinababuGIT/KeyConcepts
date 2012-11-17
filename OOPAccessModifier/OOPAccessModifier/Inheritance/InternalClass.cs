using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class InternalClass : AbstractClass
    {

        ////public override void SomeAbstractMethod()
        ////{
        ////    throw new NotImplementedException();
        ////}
        protected override void SomeAbstractMethod()
        {
            Console.WriteLine("Internal Class override some abstract method of abstract methods");
        }

        protected override void SomeVirtualMethodWithBody()
        {
           // base.SomeVirtualMethodWithBody();
            Console.WriteLine("Internal class overrride some abstract class virtual method");
        }
    }
}
