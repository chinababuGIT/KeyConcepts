using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAccess
{
    class ProgramAccess
    {
        //public, protected, private, default
        //protected internal, public intern, private internal
        //on class, properties, interface, methods, abstract class, abstract method
        //overide, virtual, new
        //static,readonly, const effect
        //Thread?, app domain? thread local


        static void Main(string[] args)
        {
            PublicInterfaceImplementor anInstance = new PublicInterfaceImplementor();
            anInstance.publicInternalInterface();

            InterfaceImplemntorFromInternalProtected implementorOnInternalProtectedInterface = new InterfaceImplemntorFromInternalProtected();
            implementorOnInternalProtectedInterface.internalProtectedInterfaceMethod();
            implementorOnInternalProtectedInterface.internalPublicInterface();

            DeriveFromInternalProtectedClass derivedClass = new DeriveFromInternalProtectedClass();
            derivedClass.internalPublicInterface();



        }
    }

}
