using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    //Write a programsuch that .
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

        static void Add(string x, string y)
        {
           // x[0]+=y[0];
            x += y;
        }

        static int foo(int[] bar, int array_size)
        {
            int i,j, temp;
            temp = 0;
            for(i=(array_size-1); i > 0; i--)
            {
                for(j=1;j<=i;j++)
                {
                       if( bar[j-1] > bar[j])
                       {
                            temp = bar[j-1];
                           bar[j-1] = bar[j];
                           bar[j]=temp;
                       }        
                }
            
            }
            var t = bar;
            Console.WriteLine(bar);
            return temp;
        }

        static void BasicStringTrimTest() 
        {
            var result = StringTrim.Trim("");
           // Console.WriteLine(result);
            result = StringTrim.Trim(null);
            Debug.Assert(result == null,"result==null");
           // Console.WriteLine(result);
            result = StringTrim.Trim(" ");
            Debug.Assert(result == null, "result==null");
            //Console.WriteLine(StringTrim.Trim(" "));
            result = StringTrim.Trim("  ");
            Debug.Assert(result == null, "result==null");
            //StringTrim.Trim("  "));
            result = StringTrim.Trim("   ");
            Debug.Assert(result == null, "result==null");
            result = StringTrim.Trim("   abc");
            Debug.Assert(result == "abc", "result==abc");
            result = StringTrim.Trim("   abc   ");
            Debug.Assert(result == "abc", "result==abc");
            result = StringTrim.Trim(" a ");
            Debug.Assert(result == "a", "result==a");
        }

        static void Main(string[] args)
        {
            //var x = new[] { "hello" };
            //var y = new[] { "world" };
            //var x = "hello";
            //var y = "world";
            //Add(x,y);
            //Console.WriteLine(x);

            //int i = 123;
            //object o = i;
            //i = 456;
            //Console.WriteLine("{0}, {1}",i, o);
            //var array = new int[]{5,4,3,2,1};
            //var temp = foo(array, 5);
            //Console.WriteLine(temp);
            //char t = (char)10;
            //int zeroCharIntValue = (int)'0';
            //t = (char)(10 + zeroCharIntValue);
            //Console.WriteLine("casting integer to char is: " + t.ToString());

            BasicStringTrimTest();
            //BasicFizzBuzzTest();
           // BasicAbbreviateStringTest();
           // BasicIntegerToStringTest();
            BasicStringToIntgerTest();
        }
    }
}
