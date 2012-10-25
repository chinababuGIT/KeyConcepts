using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathmaticQuestion
{
    //Mod and div
    //Background:
    //For input set of integers. Integer a and b.
    // a is a factor of b (a divides b) if the remainder is also an integer.
    // In math, remainder can only be non-negative, where as it is between [0, b).
    // Other forms:
    // b = q*a + r where q (quotient; +/- integer) and r(remainder).
    // As functions: q = a div b; r= a mod b
    // Please note that behaviour of % is different from math definition when comes to either 
    // argument is negative or non-integer
    
    internal static class SimpleModularArithmatic
    {
        internal static void ModMethod(int a, int b) 
        {
            int result;
            Console.WriteLine("Remainder of {0}%{1} ans: {2}", a, b, a%b);
            Console.WriteLine("Quotient of {0}/{1} ans: {2}; this is a division", a, b, a/b);
            Math.DivRem(a, b, out result);
            Console.WriteLine("Correct way of getting quotient Math.DivRem {0}", result);
            Console.WriteLine();
        }
        
        internal static void ModOnZero(int a=0, int b=0) 
        {
            Console.WriteLine("Mod on Zero: {0}, {1}", a,b);
            ModMethod(a, b);
        }

        internal static void ModOnNegative(int a, int b)
        {
            Console.WriteLine("Moding on negative numbers");
            ModMethod(a, -b);
            ModMethod(-a,b);
        }

        internal static void ModOnFloat(float a, float b)
        {
            Console.WriteLine("What if it is float, what mod will behave?");
            Console.WriteLine("{0}%{1} ans: {2}", a, b, a%b);
            Console.WriteLine("quotient {0}/{1}  {0}", a,b, a/b);
            Console.WriteLine();
        }
    }
}
