using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceAccess
{

    public interface publicPublicInterface
    {
        void Print();
    }

    interface publicInterface
    {
        //internal void publicInternalInterface(); //not valid
        void publicInternalInterface();
    }

    internal interface internalInterface
    {
        void InteternalInterface();
    }

    internal interface internalProtectedInterfaceMethod 
    {
        void internalPublicInterface();
       // internal protected void internalProtectedInterfaceMethod(); //internal protected not valid
       // virtual void virtualInterfaceMethod(); // no virtual to this method either becasue iterfacce is no about inheritnace.
    }


    //internal protected interface is not valid.. not about inheritnace.
    //internal protected interface InternalProtectedInterface
    //{
    //    void InternalProtectedInterface();
    //}
}
