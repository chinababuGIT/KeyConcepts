namespace ConcreteTypeForIOCContainer
{
    using System;
    using AbstractTypeForSimpleIOCContainer;
    public class ConcreteTypeForIOCContainer : ClassAbstract
    {
        public ConcreteTypeForIOCContainer() {
            Console.WriteLine("ConcreteTypeForIOCContainer constructed");
        }

        public override void Evaluate()
        {
            Console.WriteLine("ConcreteTypeForIOCContainer Can noe be used: Evaluate");
        }
    }
}
