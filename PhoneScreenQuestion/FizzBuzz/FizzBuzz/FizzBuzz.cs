using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static void PrintFizzBuzz(int num)
        {
            //Todo rule filtering do the most restrictive rule set first
            //especially the set is a composition of the later rules
            if (isDivisibleByBoth3And5(num))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (isDivisibleBy3(num))
            {
                Console.WriteLine("Fizz");
            }
            else if (isDivisibleBy5(num))
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        public static bool isDivisibleBy5(int num)
        {
            return (num % 5 == 0);
        }

        public static bool isDivisibleBy3(int num)
        {
            return (num % 3 == 0);
        }

        public static bool isDivisibleByBoth3And5(int num)
        {
            return isDivisibleBy3(num) && isDivisibleBy5(num);
        }
    }
}
