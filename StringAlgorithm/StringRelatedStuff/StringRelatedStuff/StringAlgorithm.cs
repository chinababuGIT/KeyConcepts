using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace StringRelatedStuff
{
    internal static class StringAlgorithm
    {
        public static int Length(string sourceString)
        { 
            if(sourceString == null) return int.MinValue;
            var _sourceCharList = sourceString.ToList<char>();
            _sourceCharList.Add('\0');
            return LengthImpl(_sourceCharList);
        }

        private static int LengthImpl(IList<char> sourceString) 
        {
            int _length = 0;
            Contract.Requires<ArgumentNullException>(sourceString != null, "String cannot be null");
            int i = 0;
            while (sourceString[i] != sourceString.Count)
            {
                ++i;
            }
            _length = i;
            Contract.EnsuresOnThrow<ArgumentException>(_length >= 0);
            return _length;
        }

        public static string Concat(string thisString, string thatString) 
        {
            if (thisString == null) return thatString;
            if (thatString == null) return thisString;
            var concatedString = ConcatImpl(thisString.ToList<char>(), thatString.ToList<char>());
            Contract.Ensures(concatedString != null);
            return concatedString;
        }
        
        private static string ConcatImpl(IList<char> thisString, IList<char> thatString) 
        {
            StringBuilder _concatedString = new StringBuilder();
            int count =0;
            while (count <= thisString.Count) 
            {
                _concatedString = _concatedString.Append(thisString[count]);
                ++count;
            }
            while (count <= thatString.Count)
            {
                _concatedString = _concatedString.Append(thatString[count]);
                ++count;
            }
            return _concatedString.ToString(0, count);
        }


        public static void ReverseString(string sourceString) 
        {
            //Test to consider null string,
            // 1 char string
            // even chars string
            // odd chars string
            if (sourceString == null) return;
            var _sourceCharList = sourceString.ToList<char>();
            ReverseStringImpl(_sourceCharList);
        }

        private static void swap(Object thischar, Object thatchar) 
        {
            Object temp = thischar;
            thischar = thatchar;
            thatchar = temp;
        }


        private static void swapChar(char thischar,  char thatchar) 
        {
            char temp = thischar;
            thischar = thatchar;
            thatchar = temp;
        }

        private static void ReverseStringImpl(IList<char> sourceString) 
        { 
            //base case: less than 1 char donothing
            //start from beginning and end:
            //   swap(beginging and end) 
            // until (ending and beginning meets or cross)
            int start =0;
            int end = sourceString.Count;
            while (start < end) 
            {
                swap(sourceString[start], sourceString[end]);
                start++; end++;
            }          
        }

        private static void ReverseStringRecuseImpl(IList<char> sourceString, int start, int end)
        {
            if (start >= end) return;
            swap(sourceString[start],sourceString[end]);
            ReverseStringRecuseImpl(sourceString, ++start, ++end);
        }


        public static void DeleteDuplicateCharInString(string sourceString) 
        {
            if (string.IsNullOrEmpty(sourceString)) return;
            StringBuilder zippedString = new StringBuilder();
            
        
        }

        public static void CompressString(string sourceString)
        {


        }

        public IList<string> PrintAllPermutation(string sourceString) 
        {
            if(String.IsNullOrEmpty(sourceString))
                return sourceString;
            IList<char> _sourceCharList = sourceString.ToCharArray().OrderByDescending();
            IList<string> result = new List<string>();
            //Build a tree such that 


            return result;
        }

        public static bool isAnagram(string thisString, string thatString) 
        {
            bool thisStringNullOrEmpty = String.IsNullOrEmpty(thisString);
            bool thatStringNullOfEmpty = String.IsNullOrEmpty(thatString);
            if (thisStringNullOrEmpty && thatStringNullOfEmpty) return true;
            if (thisStringNullOrEmpty) return false;
            if (thatStringNullOfEmpty) return false;
            return isAnagramImpl(thisString, thatString);
        }

        public static bool isAnagramImpl(string thisString, string thatString) 
        {
            int[] charMap = new int[26];
            bool ret = true;
            foreach (var item in thisString)
            {
                PutCharInMap(item, charMap);
            }

            foreach (var item in thatString) 
            {
                DeleteCharFromMap(item, charMap);
            }

            foreach (var item in charMap)
            {
                if (item != 0)
                    ret = false;
            }
            return ret;
        }

        private static void PutCharInMap(char item, int[] map)
        {
            int position = item - 'a';
            ++map[position];
        }


        private static void DeleteCharFromMap(char item, int[] map) 
        {
            int position = item - 'a';
            --map[position];
        }

        public static  bool isPalidrome(string sourceString) 
        {
            if (string.IsNullOrEmpty(sourceString)) return true;
            return isPalidromImpl(sourceString);
        }

        private static bool isPalidromImpl(string srcString) 
        {
            int start = 0; 
            int end = srcString.Length;
            bool ret = true;
            while (start < end)
            {
                //if any hapinequality pens, then it is false;
                if (srcString[start] != srcString[end])
                    ret = false;
            }

            return ret;
        }


        public static bool StringCompare(string thisString, string thatString) 
        { 
            bool thisStringNullOrEmpty = string.IsNullOrEmpty(thisString);
            bool thatStringNullOfEmpty = string.IsNullOrEmpty(thatString);
            if (thisStringNullOrEmpty && thatStringNullOfEmpty) return true;
            if (thisStringNullOrEmpty) return false;
            if (thatStringNullOfEmpty) return false;
            return StringCompareImpl(thisString, thatString);
        
        }

        private static bool StringCompareImpl(string thisString, string thatString) 
        {
            bool ret = true;
            int stringCounter = 0;
           // int thatStringCounter = 0;
           int thisStringLength = thisString.Length;
           int thatStringLength = thatString.Length;
           bool done = false;
            while(!done)
            {
                if(thisString[thisStringCounter] != thatString[thatStringCounter])
                { 
                    ret = false; 
                    break;
                }
                ++stringCounter;
               if(stringCounter == thisStringLength 
                  &&
                  stringCounter == thatStringLength)
               {
                    done = 
               }

            }
            return ret;
        
        }

        public static bool isSubString(string sourceString, string subString) 
        { 
        
        }

        public static string MergeSortedStrings(IList<string> stringSet) 
        { 
            
        
        }

        private static string mergedSortStringsImpl(IList<string> stringSet) 
        { 
            
        }

        private static string mergedSortedStringRecurseImple(IList<string> stringSet, IList<int> starts)
        { 
        
        }
        
    }
}
