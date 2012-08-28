namespace AbstractTypeForSimpleIOCContainer
{
    using System;
    using InterfaceOfComponents;

    public abstract class ClassAbstract : IClassX
    {
        public ClassAbstract(){
            Console.WriteLine("ClassAbstract constructed. Constructor included Just for demo. Not needed");
        }
               
        public abstract void Evaluate(); 
    }

}
