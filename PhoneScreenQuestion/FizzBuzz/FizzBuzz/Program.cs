using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    //Write a programsuch that 
    //when the input is divisible by 3 print Fizz  --> condition L1
    //when the input is divisible by 5 print Buzz   ---> condiiton L2
    //when the input is divisible by both 3 and 5 print Fizzbuzz --> condiiton L3: L1&L2
    class Program
    {

        static void  BasicFizzBuzzTest()
        {
           FizzBuzz.PrintFizzBuzz(15);
            FizzBuzz.PrintFizzBuzz(0); //anormally
            FizzBuzz.PrintFizzBuzz(9);
            FizzBuzz.PrintFizzBuzz(10);
            FizzBuzz.PrintFizzBuzz(30);
        }

        static void BasicAbbreviateStringTest() 
        {
            Console.WriteLine(StringIntegerConversion.AbbreviateString(""));
            Console.WriteLine(StringIntegerConversion.AbbreviateString(null));
            Console.WriteLine(StringIntegerConversion.AbbreviateString("1"));
            Console.WriteLine(StringIntegerConversion.AbbreviateString("internationalization"));
            Console.WriteLine(StringIntegerConversion.AbbreviateString("ab"));
        }

        static void BasicIntegerToStringTest() 
        {
            StringIntegerConversion.IntegerToString(0);
            StringIntegerConversion.IntegerToString(-1);
            StringIntegerConversion.IntegerToString(-9999);
            StringIntegerConversion.IntegerToString(1234567890);
            //StringIntegerConversion.IntegerToString(null);

        }

        static void BasicStringToIntgerTest() 
        {
            StringIntegerConversion.StringToInteger(null);
            StringIntegerConversion.StringToInteger("0");
            StringIntegerConversion.StringToInteger("-1");
            StringIntegerConversion.StringToInteger("1");
            StringIntegerConversion.StringToInteger("-12345");
            StringIntegerConversion.StringToInteger("12345");
        }

        static void Main(string[] args)
        {
            char t = (char)10;
            int zeroCharIntValue = (int)'0';
            t = (char)(10 + zeroCharIntValue);
            Console.WriteLine("casting integer to char is: " + t.ToString());

           // BasicFizzBuzzTest();
           // BasicAbbreviateStringTest();
           // BasicIntegerToStringTest();
            BasicStringToIntgerTest();
        }
    }
}
