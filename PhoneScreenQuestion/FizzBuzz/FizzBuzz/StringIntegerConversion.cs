using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class StringIntegerConversion
    {

        public static string AbbreviateString(string sourceString)
        {
            //Say string is internationalization, we keep the first and last character
            //everything in the middle becomes a number; that number is a count of characters
            //in between the first and last character.
            String result = null;
            if (sourceString == null) return result;
            int length = sourceString.Length;
            if (length < 2) return result;
            char firstChar = sourceString[0];
            char lastChar = sourceString[length - 1];
            int count = length - 2;
            result = String.Empty;
            result = result + firstChar.ToString();
            result = result + count.ToString();
            result = result + lastChar.ToString();
            return result;
        }

        public static string IntegerToString(int num)
        {
            StringBuilder result = null;
            char sign = isNegative(num);
            //The key is to extract each digit convert to char
            //and piece it back.
            int remainder = -1;
            int div = -1;
            int zeroCharBase = (int)'0';
            num = Math.Abs(num);
            Stack<char> _charStack = new Stack<char>();
            do
            {
                div = num / 10;
                remainder = num % 10;
                num = div;
                _charStack.Push((char)(remainder+zeroCharBase));
            }
            while ( div >= 1);
            result = new StringBuilder(_charStack.Count +1);
            result = result.Append(sign);
            for (int i = _charStack.Count; i > 0; --i)
            {
                result = result.Append(_charStack.Pop());
            }
            Console.WriteLine("int-to-stirng: " + result.ToString());
            return result.ToString();
        }

        public static double StringToInteger(string sourceString)
        {
            double result = double.MinValue;
            string passedInString = sourceString;
            if (String.IsNullOrEmpty(sourceString))
                return result;
            bool isPositive = GetSign(sourceString[0]);
            sourceString = GetString(sourceString);

            sourceString = sourceString.Reverse();

            int digitLength = sourceString.Length;
            double sum = 0;
            double j = 0.0;
            for (int i = digitLength - 1; i >= 0; --i)
            {
                j = i* 1.0;
                double tenBase = Math.Pow(10.0, j);
                double sumDigit = CharToDigit(sourceString[i]);
                sum = sum + tenBase * sumDigit;
            };
            if (!isPositive)
                result =-sum;
            else
                result = sum;
            Console.WriteLine(string.Format("StringToInteger: str va \"{0}\" int val {1}", passedInString, result));
            return result;
        }

        static char isNegative(int num)
        {
            return (num < 0) ? '-' : '+';
        }

        static char DigitToChar(int digit) 
        {
            char result = char.MinValue;
            int index = digit - (int)'0';
            if( index >= 0 && index < 10)
            {
                char[] charMap = {'0','1','2','3','4','5','6','7','8','9'};
                result = charMap[index];
            }
            return result;
        }

        static int CharToDigit(char charDigit) 
        {
            int result = int.MinValue;
            int index = charDigit - (int)'0';          
            if (index >= 0 && index < 10) 
            {
                int[] charToIntMap = {0,1,2,3,4,5,6,7,8,9};
                result = charToIntMap[index];            
            }
            return result;
        }
       
        static string GetString(string digitString) 
        {
            string result = digitString;
            if (digitString[0].CompareTo('-') == 0
                ||
                digitString[0].CompareTo('+') == 0
                )
            {
                result = digitString.Substring(1);
            };

            return result;
        }

        static bool GetSign(char firstChar)
        {
            if (firstChar.CompareTo('-') == 0)
            {
                return false;
            }
            if (firstChar.CompareTo('+') == 0)
            {
                return true;
            }
            return true;
        }

        static string Reverse(this string sourceString)
        {
            if (String.IsNullOrEmpty(sourceString)) 
                return sourceString;
            int i = 0; int j = sourceString.Length -1;
            char[] stringChar =sourceString.ToCharArray();
            while (i <= j) 
            { 
               char temp = stringChar[i];
               stringChar[i] = stringChar[j];
               stringChar[j] = temp;
               ++i;
               --j;
            }
            return new String(stringChar);
        }

    }
}
