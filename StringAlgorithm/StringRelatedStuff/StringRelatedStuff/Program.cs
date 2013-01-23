using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringRelatedStuff
{
    class Program
    {

        static void BasicStringReverseTest() {
            var result = StringUtil.ReverseString("a");
            Debug.Assert(result =="a");
            result = StringUtil.ReverseString("");
            Debug.Assert(result == "");
            result = StringUtil.ReverseString("ab");
            Debug.Assert(result == "ba");
            result = StringUtil.ReverseString(null);
            Debug.Assert(result == null);
            result = StringUtil.ReverseString("abc");
            Debug.Assert(result == "cba");
            result = StringUtil.ReverseString("abcde");
            Debug.Assert(result=="edcba");
        }

        static void BasicStringIntersectionTest() {
            var result = StringUtil.Intersection("", null);
            Debug.Assert(result == string.Empty);
            result = StringUtil.Intersection(null, null);
            Debug.Assert(result == string.Empty);
            result = StringUtil.Intersection(null, "");
            Debug.Assert(result == string.Empty);
            result = StringUtil.Intersection("", "");
            Debug.Assert(result == string.Empty);
            result = StringUtil.Intersection("aaa", "aaaa");
            Debug.Assert(result == "aaa");
            result = StringUtil.Intersection("aba", "aba");
            Debug.Assert(result == "aba");

            result = StringUtil.Intersection("abcde", "ab");
            Debug.Assert(result == "ab");

            result = StringUtil.Intersection("ab", "abcde");
            Debug.Assert(result == "ab");

            result = StringUtil.Intersection("ab", "de");
            Debug.Assert(result == string.Empty);

            result = StringUtil.Intersection("ab", "be");
            Debug.Assert(result == "b");

            result = StringUtil.Intersection("ach", "bceh");
            Debug.Assert(result == "bh");


        }

        static void Main(string[] args)
        {
            //BasicStringReverseTest();
            BasicStringIntersectionTest();
        }
    }
}
