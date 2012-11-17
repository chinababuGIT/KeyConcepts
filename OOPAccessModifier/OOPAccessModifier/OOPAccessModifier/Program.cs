using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceAccess;
namespace OOPAccessModifier
{
    class SomeClass : publicPublicInterface
    {

        public void Print()
        {
            Console.Write("Print public public interface. Interface public from another assembly ");
        }
    }

    class Program
    {
        //public, proteccted, private, default
        //protected internal, public intern, private internal
        //on class, properties, interface, methods, abstract class, abstract method
        //overide, virtual, new
        //static,readonly, const effect
        //Thread?, app domain? thread local


        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            someClass.Print();
           
        }
    }
}
