using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAccess
{

    internal class PublicInterfaceImplementor : publicInterface, publicPublicInterface
    {
        public void publicInternalInterface()
        {
            Console.WriteLine("implements public inteface but visible to same assembly.");
        }

        public void Print()
        {
            Console.WriteLine("implements public public interface");
        }
    }

    internal class InterfaceImplementor : internalInterface
    {
        public void InteternalInterface()
        {
            Console.WriteLine( "Implements internal public Interface, same as just marked interface with nothing. default behaviour");
        }
    }

    internal class InterfaceImplemntorFromInternalProtected : internalProtectedInterfaceMethod
    {
        public void internalPublicInterface()
        {
            Console.WriteLine("NO SUCH THINg. Internal Protected public Interface, NO SUCH THING");
        }

        public void internalProtectedInterfaceMethod()
        {
            Console.WriteLine("NO SUCH THING. Internal rotected interface method,NO SUCH THINg");
        }
    }

    internal class DeriveFromInternalProtectedClass : InterfaceImplemntorFromInternalProtected
    { 
    
    }
}
