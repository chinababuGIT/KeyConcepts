using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRelatedStuff
{
    public static class StringUtil
    {
        public static Tuple<int,int> Find(string source, string substring) 
        {
            Tuple<int, int> result = new Tuple<int, int>(0,0);

            return result;
        }


        public static string ReverseString(string source) 
        { 
           string result = null;
           if (String.IsNullOrEmpty(source))
           {
               result = source;
           }
           else
           {
               char[] stringChar = source.ToCharArray();
               int start = 0;
               int end = stringChar.Length - 1;
               while(start < end){
                   char temp = stringChar[start];
                   stringChar[start] = stringChar[end];
                   stringChar[end] = temp;
                   ++start; --end;
               }
               result = new String(stringChar);
           }
           return result;
        }

        public static Tuple<string, string> UncommonString(string leftString, string rightString)
        {
            Tuple<string, string> result = new Tuple<string, string>(leftString, rightString);


            return result;
        }

        public static string MergedString(string leftString, string rightString) 
        {
            string result = string.Empty;

            return result;
        }

        //presort the strings
        public static string Intersection(string leftString, string rightString) 
        {
            string result = string.Empty;
            bool leftStringNullOrEmpty = string.IsNullOrEmpty(leftString);
            bool rightStringNullOrEmpty = string.IsNullOrEmpty(rightString);
            if (leftStringNullOrEmpty || rightStringNullOrEmpty)
            {
                return result;
            }
            else 
            {
                int leftStart = 0;
                int rightStart = 0;
                int leftStringLength = leftString.Length;
                int rightStringLength = rightString.Length;
                char[] leftCharString = leftString.ToCharArray();
                char[] rightCharString = rightString.ToCharArray();

                int length = Math.Min(leftStringLength,rightStringLength);
                char[] charResult = new char[length];
                int i =0;

                while( leftStart < leftStringLength 
                    && rightStart < rightStringLength)
                {
                    if (leftCharString[leftStart] == rightCharString[rightStart])
                    {
                        charResult[i] = leftCharString[leftStart];
                        ++i;
                        ++leftStart;
                        ++rightStart;
                    }
                    else if (leftCharString[leftStart] < rightCharString[rightStart])
                    {
                        ++leftStart;
                    }
                    else if (leftCharString[leftStart] > rightCharString[rightStart])
                    {
                        ++rightStart;
                    };
                };

                if (i > 0)
                {
                    if (leftStart < rightStart)
                    {
                        for (int j = rightStart; j < rightStringLength; ++j)
                        {
                            if (leftCharString[leftStart] == rightCharString[rightStart])
                            {
                                charResult[++i] = leftCharString[leftStart];
                            }
                            else
                            {
                                ;
                            }
                        }
                    };

                    if (leftStart > rightStart)
                    {
                        for (int j = rightStart; j < leftStringLength; ++j)
                        {
                            if (leftCharString[leftStart] == rightCharString[rightStart])
                            {
                                charResult[++i] = rightCharString[leftStart];
                            }
                            else
                            {
                                ;
                            }
                        }

                    };
                    result = new String(charResult);
                }
                else 
                {
                    result = string.Empty;
                };
            }
            return result;
        
        }

        public static string RemoveSubString(string source, string subString) 
        {
            string result = string.Empty;

            return result;        
        }


    }
}
