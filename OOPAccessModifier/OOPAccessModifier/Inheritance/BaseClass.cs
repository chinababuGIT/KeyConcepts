using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class BaseClass
    {
        protected virtual void ProtectedBaseMethod() 
        {
            Console.WriteLine("Protected Base Method");
        }

        //public abstract void BaseClassAbstractMethodNotAllowed;
    }

    class ChildProtectedClassWrapper {
        protected class ChildClass : BaseClass 
        {
            protected override void ProtectedBaseMethod()
            {
                base.ProtectedBaseMethod();
                Console.WriteLine("Specialization of base method by a protected child class");
            }
        }
    }
    class ChildPrivateClassWrapper 
    {
        private class ChildPrivateClass : BaseClass 
        {
            protected override void ProtectedBaseMethod()
            {
                base.ProtectedBaseMethod();
                Console.WriteLine("Specialization of base method by a private child class");
            }
        }


        //CANNOT DO, child class got less restricted access on abstract clas which is meant to be internal
        //public class ChildPublicClass : AbstractPublicInternalClass
        //{ 
        
        //}
        internal class ChildInternalClass : AbstractPublicInternalClass
        {
            protected override void SomeAbstractMethod()
            {
                //throw new NotImplementedException();
            }
        }

        internal protected class ChildInternalProtectedClass : AbstractPublicInternalClass
        {
            protected override void SomeAbstractMethod()
            {
                //throw new NotImplementedException();
            }
        }
    
    }
}
