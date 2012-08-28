namespace ClassCImpl
{
    using System;
    using InterfaceOfComponents;

    public class ClassCImpl : IClassX
    {
        public void Evaluate()
        {
            Console.WriteLine("ClassCImpl is called");
        }
    }
}
