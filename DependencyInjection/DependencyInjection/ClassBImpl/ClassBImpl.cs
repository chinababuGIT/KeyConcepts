namespace ClassBImpl
{
    using System;
    using InterfaceOfComponents;

    public class ClassBImpl : IClassX
    {
        public void Evaluate()
        {
            Console.WriteLine("ClassBImpl is called");
        }
    }
}
