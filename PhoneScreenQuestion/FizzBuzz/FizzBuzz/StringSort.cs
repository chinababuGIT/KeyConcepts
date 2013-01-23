using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    //internal class StringSort
    //{
    //    public static string MergerString(string a, string b)
    //    {
    //        string mergedString = null;
    //        if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b)) 
    //        {
    //            return mergedString;
    //        };
            
    //        if(string.IsNullOrEmpty(a))
    //        {
    //            return b;
    //        }
    //        if(string.IsNullOrEmpty(b))
    //        {
    //            return a;
    //        }
    //        mergedString = mergeStringImpl(a,b);
    //        return mergedString;
    //    }

    //    private static string mergeStringImpl(string a, string b) 
    //    { 
    //        //case 2 null, return null
    //        //case 1 null, concat return non null
    //        //case 3 both non null
    //        //     3a same length
    //        //     3b different length , then append.

    //        int strAiength = a.Length;
    //        int strBLength = b.Length;

    //    }
        
    //    public static string sort2BitString(string a, char[] alphabet) 
    //    { 
    //        if(string.IsNullOrEmpty(a)) return a;
    //        if (alphabet.Length == 2) throw new ArgumentException("string alphabets is incorrect");
    //        alphabet.Sort();
    //        int strLength = a.Length;
    //        char[] charArray = a.ToCharArray();
    //        for (int i = 0; i < strLength -1; i++) 
    //        {
    //            if (charArray[i] > charArray[i + 1])
    //            { 
    //                char temp= charArray[0];
    //                charArray[0] = charArray[1];
    //                charArray[1] = temp;
    //            }
    //        }
                
    //    }

    //    static char[] Sort(this char[] a)
    //    {
    //        if(a[0] > a[1])
    //        {
    //           char temp= a[0];
    //           a[0] = a[1];
    //           a[1] = temp;
    //        }
    //    }

    //    public static string sort3BitString(string a)
    //    {
    //        if (string.IsNullOrEmpty(a)) return a;

    //    }

    //    public static void PrintAllString(string a)
    //    {
    //        if (string.IsNullOrEmpty(a)) return a;
    //    }
    //}
}
