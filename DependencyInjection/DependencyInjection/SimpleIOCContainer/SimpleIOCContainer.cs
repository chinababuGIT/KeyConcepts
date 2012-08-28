namespace SimpleIOCContainer
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using ISimpleIOCContainter;
    //using InterfaceOfComponents;
    //using AbstractTypeForSimpleIOCContainer;

    public class SimpleIOCContainer : ISimpleIOCContainer
    {
        private readonly IDictionary<Type, Type> registry = new Dictionary<Type, Type>();

        //Concept point. We want to store whats the implementation we found on runtime 
        //against the contract type the client caller has. Client caller is coded against
        //Interface.
        public void Register<TContract, TImplementation>()
        {
            //Concept point. readonly field constructor init only apply to primitive type
            //this.registry = new Dictionary<Type, Type>();
            registry[typeof(TContract)] = typeof(TImplementation);
        }

        public TContract Resolve<TContract>()
        {
            return (TContract)Resolve(typeof(TContract));
        }

        public object Resolve(Type contract) {
            Type implementation = registry[contract];
            ConstructorInfo constructor = implementation.GetConstructors()[0];
            ParameterInfo[] numberOfParameter = constructor.GetParameters();
            if (numberOfParameter.Length ==  0) //We ahve a default constructor
                return Activator.CreateInstance(implementation);
            return null; //Don't care other cases jsut demo at this point
          
        }
    }
}
