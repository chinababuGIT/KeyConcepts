using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class ProgramEntryPoint
    {
        static int main(String[] arg) 
        {
            ProtectedClass someClass = new ProtectedClass();
            someClass.AbstractPublicMethod();
            someClass.AbstractProtectedInternalMethod();

            InternalClass someInternalClass = new InternalClass();
            someInternalClass.AbstractPublicMethod();
            someInternalClass.AbstractProtectedInternalMethod();

            return 0;
        }
    }
}
