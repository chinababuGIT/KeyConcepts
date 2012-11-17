using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    abstract class AbstractClass
    {
        // Abstract class is meants to be abse class. NO POINT of hiding the method
        // that are intended to be inherited and extended like virtual or abstract methods
        //virtual void SomevirtualMethod();
        //virtual void SomeVirtualMethodWithBody()
        //{
        //    Console.WriteLine("Virtual Method with Body");
        //}

        //abstract void SomeAbstractMethod();

        //abstract void SomeAbstractMethodWthBody()
        //{
        //    AbstractPrivateMethod();
        //    Console.WriteLine("Abstract Method with body");
        //}

        //private void AbstractPrivateMethod()
        //{
        //    Console.WriteLine("Abstact Private Method");
        //}

        //protected virtual void SomevirtualMethod();
        protected virtual void SomeVirtualMethodWithBody()
        {
            Console.WriteLine("Virtual Method with Body");
        }

        protected abstract void SomeAbstractMethod();

        //protected abstract void SomeAbstractMethodWthBody()
        //{
        //    AbstractPrivateMethod();
        //    Console.WriteLine("Abstract Method with body");
        //}

        private void AbstractPrivateMethod()
        {
            Console.WriteLine("Abstact Private Method");
        }



        protected void AbstractProtectedMetod()
        {
            Console.WriteLine("Abstract Protected Method");
        }

        protected internal void AbstractProtectedInternalMethod()
        {
            Console.WriteLine("Abstract protected internal method");
        }
        public void AbstractPublicMethod()
        {
            Console.WriteLine("Abstract public method");
        }
    }

    //ABSTRACT class is meant to be inherited. No point of getting it be privated.
    //Protected is dupilicate in meaning. 

    //private abstract class AbstractPrivateClass  
    //{
    //    virtual void SomevirtualMethod();
    //    virtual void SomeVirtualMethodWithBody()
    //    {
    //        Console.WriteLine("Virtual Method with Body");
    //    }

    //    abstract void SomeAbstractMethod();

    //    abstract void SomeAbstractMethodWthBody()
    //    {
    //        AbstractPrivateMethod();
    //        Console.WriteLine("Abstract Method with body");
    //    }

    //    private void AbstractPrivateMethod()
    //    {
    //        Console.WriteLine("Abstact Private Method");
    //    }

    //    protected void AbstractProtectedMetod()
    //    {
    //        Console.WriteLine("Abstract Protected Method");
    //    }

    //    protected internal void AbstractProtectedInternalMethod()
    //    {
    //        Console.WriteLine("Abstract protected internal method");
    //    }
    //    public void AbstractPublicMethod()
    //    {
    //        Console.WriteLine("Abstract public method");
    //    }
    //}

    //protected abstract class AbstractProtectedClass 
    //     {
    //    virtual void SomevirtualMethod();
    //    virtual void SomeVirtualMethodWithBody()
    //    {
    //        Console.WriteLine("Virtual Method with Body");
    //    }

    //    abstract void SomeAbstractMethod();

    //    abstract void SomeAbstractMethodWthBody()
    //    {
    //        AbstractPrivateMethod();
    //        Console.WriteLine("Abstract Method with body");
    //    }

    //    private void AbstractPrivateMethod()
    //    {
    //        Console.WriteLine("Abstact Private Method");
    //    }

    //    protected void AbstractProtectedMetod()
    //    {
    //        Console.WriteLine("Abstract Protected Method");
    //    }

    //    protected internal void AbstractProtectedInternalMethod()
    //    {
    //        Console.WriteLine("Abstract protected internal method");
    //    }
    //    public void AbstractPublicMethod()
    //    {
    //        Console.WriteLine("Abstract public method");
    //    }
    //}
    
    //protected internal abstract class AbstractProtectedInternalClass  
    //     {
    //    virtual void SomevirtualMethod();
    //    virtual void SomeVirtualMethodWithBody()
    //    {
    //        Console.WriteLine("Virtual Method with Body");
    //    }

    //    abstract void SomeAbstractMethod();

    //    abstract void SomeAbstractMethodWthBody()
    //    {
    //        AbstractPrivateMethod();
    //        Console.WriteLine("Abstract Method with body");
    //    }

    //    private void AbstractPrivateMethod()
    //    {
    //        Console.WriteLine("Abstact Private Method");
    //    }

    //    protected void AbstractProtectedMetod()
    //    {
    //        Console.WriteLine("Abstract Protected Method");
    //    }

    //    protected internal void AbstractProtectedInternalMethod()
    //    {
    //        Console.WriteLine("Abstract protected internal method");
    //    }
    //    public void AbstractPublicMethod()
    //    {
    //        Console.WriteLine("Abstract public method");
    //    }
    //}

    public abstract class AbstractPublicClass  
         {
        //protected virtual void SomevirtualMethod();
        protected virtual void SomeVirtualMethodWithBody()
        {
            Console.WriteLine("Virtual Method with Body");
        }

        protected abstract void SomeAbstractMethod();

        //protected abstract void SomeAbstractMethodWthBody()
        //{
        //    AbstractPrivateMethod();
        //    Console.WriteLine("Abstract Method with body");
        //}

        private void AbstractPrivateMethod()
        {
            Console.WriteLine("Abstact Private Method");
        }

        protected void AbstractProtectedMetod()
        {
            Console.WriteLine("Abstract Protected Method");
        }

        protected internal void AbstractProtectedInternalMethod()
        {
            Console.WriteLine("Abstract protected internal method");
        }
        public void AbstractPublicMethod()
        {
            Console.WriteLine("Abstract public method");
        }
    }

    internal abstract class AbstractPublicInternalClass
    {
        //What is difference between VIRTUAL mehod vs abstract method?
        //virtual method has body where abstract method is like virtual = 0 
        //protected virtual void SomevirtualMethod();
        protected virtual void SomeVirtualMethodWithBody()
        {
            Console.WriteLine("Virtual Method with Body");
        }

        protected abstract void SomeAbstractMethod();

        // NOT VALID ABStract marker means virtual = 0 in C++.
        //protected abstract void SomeAbstractMethodWthBody()
        //{
        //    AbstractPrivateMethod();
        //    Console.WriteLine("Abstract Method with body");
        //}

        private void AbstractPrivateMethod()
        {
            Console.WriteLine("Abstact Private Method");
        }

        protected void AbstractProtectedMetod()
        {
            Console.WriteLine("Abstract Protected Method");
        }

        protected internal void AbstractProtectedInternalMethod()
        {
            Console.WriteLine("Abstract protected internal method");
        }
        public void AbstractPublicMethod()
        {
            Console.WriteLine("Abstract public method");
        }
    }
}
