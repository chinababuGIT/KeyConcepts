using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MathmaticQuestion
{
    // For integers a, b. If there is a Set of divisors for both a and b say D
    // GreatestCommonDivisor of a and b ( gcd(a,b)) is the largest element from D.
    // Algorithm gcd(c,d).
    // We can solve gcd by recursion because of the following property.
    // When d divides a and b completely, it means the following cases:
    // case1 : a = b.
    // case2 : a > b.
    // case3 : a < b.
    // For a > or < b, it means that the difference between a and b or (a - b) will
    // be a multiple of d.
    // Hence for:
    // case1: d is either a or b. because a=b. 
    // case2: (a-b)= kd, where k is an integer between 0 to some postive integer.
    //        the gcd is kd when k is minimum, making d the maximum
    //        all together this means:
    //        If d is the gcd of a and b, then
    //        -- d divides a
    //        -- d divides b
    //        -- d divides (a-b) assuming a > b 
    //        To find d, we are going to make it as fast as possible.
    //        since (a-b) and b are the smaller numbers of the three, we will find the gcd of them.
    //         and the argument recurse; until it reaches case 1 where a is b. or (a-b) is 0
    // case3: it is just case2 with a minus sign in front.



    internal static class GreatestCommonDivisor
    {
        //cass to consider:
        // gcd(0,0) is undefined
        // gcd(0,a) is 0
        // since gcd(a,b) = gcd(b,a); gcd(a,0) is also 0
        // gcd(1,a) is 1
        static int gcd(int a, int b)
        {
            if (a == 0) return Math.Abs(a);
            if (b == 0) return Math.Abs(b);    
            int remainder = (b - a);
        
            remainder = Math.Abs(b - a);
            if (remainder == 0) 
                return a;
            else
                return gcd(b, remainder);
        }

        internal static void GcdNormal() 
        {
            Console.WriteLine("Normal Gcd(10,5)");
            Console.WriteLine("gcd(10, 5): {0}", gcd(10,5));
            Console.WriteLine("gcd(5, 10): {0}",gcd(5, 10));
            Console.WriteLine("gcd(50, 10000): {0}", gcd(50, 10000));
            Console.WriteLine("gcd(50, 999): {0}", gcd(50, 999));
            Console.WriteLine("Gcd of 0");
            Console.WriteLine("gcd(0, 10): {0}",gcd(0, 10));
            Console.WriteLine("gcd(10, 0): {0}",gcd(5, 0));
            Console.WriteLine("gcd(0, 0): {0}",gcd(0, 0));
            Console.WriteLine("Gcd of negative numbers");
            Console.WriteLine("gcd(-10, 5): {0}",gcd(-10, 5));
            Console.WriteLine("gcd(5, -10): {0}",gcd(5, -10));
        }
    }
}
