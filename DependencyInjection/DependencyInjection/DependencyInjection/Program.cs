namespace DependencyInjection
{
    using System;
    using InterfaceOfComponents;
    using ClassBImpl;
    using ClassCImpl;
    using DependencyInjectionExample;

    class Program
    {
        static void Main(string[] args)
        {
            //Case 1 using Class B
            Console.WriteLine("Mai progrram now acts as the IOC container. But it can be done runtime via refelction and reading the app config");

            //Case 1 using Class B
            Console.WriteLine("Case 1. Class A use B.");
            ClassA AuseB = new ClassA(new ClassBImpl());
            AuseB.DoSomething();

            //Case 2 using Class C
            Console.WriteLine("Case 2. Class A use C.");
            ClassA AuseC = new ClassA(new ClassCImpl());
            AuseC.DoSomething();
        }
    }
}
