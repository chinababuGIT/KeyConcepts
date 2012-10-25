using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathmaticQuestion
{
    class Program
    {
        static void SimpleModOpertorDemo() 
        {
            SimpleModularArithmatic.ModMethod(10, 5);
            SimpleModularArithmatic.ModMethod(5, 10);
            SimpleModularArithmatic.ModMethod(1, 10);

            SimpleModularArithmatic.ModOnNegative(20, 15);
            SimpleModularArithmatic.ModOnFloat(10.5f, 5.3f);
            try
            {
                SimpleModularArithmatic.ModOnZero(15);
                SimpleModularArithmatic.ModOnZero();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\n DivdeByZeroException " + ex);
            }        
        
        }

        static void GcdSampleTest()
        {
            GreatestCommonDivisor.GcdNormal();
        }

        public static void Main(string[] args)
        {
            //SimpleModOpertorDemo();
            GcdSampleTest();
        }
    }
}
