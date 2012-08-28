namespace DependencyInjectionExample
{
    using System;
    using InterfaceOfComponents;

    //Note that Class A Does NOT Even has reference to eitehr Class B or C!!!
    //You know you can now drop the dll!!!
    public class ClassA
    {
        private readonly IClassX _classX;
        public ClassA(IClassX classXImpl) 
        {
            if (classXImpl != null)
                this._classX = classXImpl;

        }

        public void DoSomething() 
        {
            if (this._classX != null)
                _classX.Evaluate();
            Console.WriteLine("Class A is constructed");
        }
    }
}
