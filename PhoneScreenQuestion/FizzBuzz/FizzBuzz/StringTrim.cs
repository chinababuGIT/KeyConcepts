using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class StringTrim
    {
        public static string Trim(string source)
        {
            string result = null;
            char charToTrim = ' ';
            if (string.IsNullOrEmpty(source))
            { 
                result = source; 
            }
            else 
            {
                int start = 0;
                int end = source.Length -1;
                bool startNotFound = true;
                bool endNotFound = true;
                bool stop = startNotFound & endNotFound;

                while( (start <= end ) && stop)
                {
                    if (source[start] == charToTrim)
                    {
                        ++start;
                    }
                    else 
                    {
                        startNotFound = false;
                    }
                    if (source[end] == charToTrim)
                    {
                        --end;
                    }
                    else 
                    {
                        endNotFound = false;
                    }

                    if (!startNotFound && !endNotFound)
                        stop = false;
                };

               

                if (start <= end) 
                {
                   
                    int length = end - start +1;
                    result = source.Substring(start, length);
                    //if (length > 0)
                    //{
                    //    char[] toCopy = new char[length];
                    //    int i = start;
                    //    int j = 0;

                    //    while(i <= end && j < length)
                    //    {
                    //        toCopy[j] = source[i];
                    //        ++i;
                    //        ++j;
                    //    }

                    //    result = new String(toCopy);
                    //}
                }

            }
            return result;
        }
    }
}
