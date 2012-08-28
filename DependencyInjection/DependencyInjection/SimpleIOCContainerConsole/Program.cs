namespace SimpleIOCContainerConsole
{
    using System;
    using SimpleIOCContainer;
    using AbstractTypeForSimpleIOCContainer;
    using ConcreteTypeForIOCContainer;
    using InterfaceOfComponents;

    using ClassBImpl;

    internal class SomeClient {
        IClassX _toBeUsedLaterOn;
        private  readonly string instanceTypeName;
        internal SomeClient(IClassX tbd, string typeUsed)
        {
            this._toBeUsedLaterOn = tbd;
            this.instanceTypeName = typeUsed;
        }

        internal void DoSometing()
        {
            Console.WriteLine("SomeClient uses type {0} got from IOCContainer as long as contract satistified", instanceTypeName);
            _toBeUsedLaterOn.Evaluate();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //Note that the client code only code against the types of IClassX 
            //
            SimpleIOCContainer simpleContainer = new SimpleIOCContainer();
            //Case 1. use Class derived form abstractclass
            simpleContainer.Register<IClassX, ConcreteTypeForIOCContainer>();
            var _toBeUsedLaterOn = simpleContainer.Resolve<IClassX>();
            SomeClient someclient = new SomeClient(_toBeUsedLaterOn, "ConcreteTypeForIOCContainer");
            someclient.DoSometing();
            Console.WriteLine();
            //Case 2. Uses Class B implements interface
            simpleContainer.Register<IClassX, ClassBImpl>();
            var resolveToB = simpleContainer.Resolve<IClassX>();
            SomeClient someClientUseB = new SomeClient(resolveToB,"ClassBImpl");
            someClientUseB.DoSometing();



        }
    }
}
