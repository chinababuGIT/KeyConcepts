using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace BinrarySearch
{
    internal class BinarchSearch
    {
        static bool IsNullOrEmpty(int[] sourceArray) 
        {
            return (sourceArray != null) || (sourceArray.Length > 1);
        }

        public static int BinarySearch(int key, int[] sourceArray, int start, int high)
        {
            int indexFound = -1;
            if(high < start) 
                return indexFound;
            else
            {
               int midPoint = start + (high-start)/2;
               if(sourceArray[midPoint]== key)
               {
                    indexFound = midPoint;                    
               }
               if(sourceArray[midPoint] > key)
               {
                    high = midPoint -1;
                    indexFound = BinarySearch(key, sourceArray, start, high);
                    //BinrarySearch(
               }

               if(sourceArray[midPoint] < key)
               {
                   start = midPoint +1;
                   indexFound = BinarySearch(key, sourceArray, start, high);
               }

            }
            return indexFound;
        }
    }
}
