using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Seraching
{
    internal class LinearSearch
    {
        public static int FindItem(IEnumerable<int> someSource, int itemToSearchFor)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            int location = int.MinValue; // not found;
            int index = 0;
            foreach (var item in someSource)
            {
                if (item == itemToSearchFor)
                {
                    location = index;
                }
                else
                {
                    ++index;
                }
            }

            return location;
        }

        public static int FindItemRecurrsion(IEnumerable<int> someSource, int itemToSearchFor)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            return FindItemRecurrsionInternal(someSource, itemToSearchFor, 0);
        }

        public static int FindItemRecurrsionInternal(IEnumerable<int> someSource, int itemToSearchFor, int index)
        {
            if (index > someSource.Count())
                return int.MinValue;
            if (someSource.ElementAt(index) == itemToSearchFor)
                return index;
            else
                return FindItemRecurrsionInternal(someSource, itemToSearchFor, index + 1);
        }

        private static int FindMax(IEnumerable<int> someSource)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            var maxSoFar = someSource.First(); //there should be

            foreach (var item in someSource)
            {
                if (maxSoFar < item)
                {
                    maxSoFar = item;
                }
            }
            return maxSoFar;
        }

        public static int FindMaxRecurrsion(IEnumerable<int> someSource)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            var maxSoFar = someSource.First();
            maxSoFar = FindMaxRecurrsionInternal(someSource, maxSoFar, 0);
            return maxSoFar;
        }

        private static int FindMaxRecurrsionInternal(IEnumerable<int> source, int maxSoFar, int index)
        {
            //Base case;
            if (index > source.Count())
            { 
                return int.MinValue; 
            }
            var item = source.ElementAt(index);
            if (maxSoFar < item)
            {
                maxSoFar = item;
            }
            return FindMaxRecurrsionInternal(source, maxSoFar, index + 1);
        }

        private static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static int FindSecondMax(IEnumerable<int> someSource)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            Contract.Requires(someSource.Count() > 1, "Source Set should have at least 2 elements");
            int maxSoFar = someSource.ElementAt(0);
            int secondMaxSoFar = someSource.ElementAt(1);

            if (maxSoFar < secondMaxSoFar)
                swap(ref maxSoFar, ref secondMaxSoFar);
                
            //This is the same as ordering
            //an unordered sequence of x,y,z
            //but perform the procedure on the whole set
            //Case to consider:
            //1 item set
            //2 item set
            //sets with duplicates

            foreach (var item in someSource) 
            {
                if (secondMaxSoFar < item)
                {
                    secondMaxSoFar = item;

                    if (maxSoFar < secondMaxSoFar)
                    {
                        swap(ref maxSoFar, ref secondMaxSoFar);        
                    }
                }
            }

            return secondMaxSoFar;
        }


        public static int FindSecondMaxRecussion(IEnumerable<int> someSource)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            Contract.Requires(someSource.Count() > 2,"someSource must have at least 2 elements");
            int maxSofar = someSource.ElementAt(0);
            int secondMaxSoFar = someSource.ElementAt(1);
            if(maxSofar < secondMaxSoFar)
                swap(ref maxSofar, ref secondMaxSoFar);
            secondMaxSoFar = FindSecondMaxRecurrsionInternal(someSource, maxSofar,secondMaxSoFar, 1);
            return secondMaxSoFar;
        }

        private static int FindSecondMaxRecurrsionInternal(IEnumerable<int> someSource, int maxSoFar, int secondMaxSoFar, int index)
        {
           

        }

        public static int FindKthMax(IEnumerable<int> someSource, int kthMax)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            Contract.Requires( kthMax <= someSource.Count(),
                              string.Format("Must have at least {0} element in set",kthMax));
            var kthMax = int.MinValue;
            foreach(var item in someSource)
            {
                
            }
            return kthMax;
        }

        public static Tuple<int, int> FindMaxMin(IEnumerable<int> someSource)
        {
            EnsureSourceNotNullOrEmpty(someSource);
            int maxSoFar = someSource.ElementAt(0);
            int minSoFar = someSource.ElementAt(0);
            foreach (var item in someSource)
            {
                if (maxSoFar < item)
                {
                    maxSoFar = item;
                }
                if (minSoFar > item)
                {
                    minSoFar = item;
                }     
            }
            return new Tuple<int, int>(maxSoFar, minSoFar);

        }

        private static void EnsureSourceNotNullOrEmpty(IEnumerable<int> source)
        {
            Contract.Requires(source != null, "source cannot be null");
            Contract.Requires(source.Count() > 0, "source cannot be empty");
        }

        private static int IsOutofOrder(IEnumerable<int> source, Func<int,int,bool> comparer)
        {
            EnsureSourceNotNullOrEmpty(source);
            int index= int.MinValue;
            var count = source.Count();
            if( count >1)
            {
                for (int i = 0; i < count; ++i)
                { 
                    if(comparer(source.ElementAt(i), source.ElementAt(i+1)) == false)
                    {
                        index = i;
                        break;
                    }
                }
            }


            return index;
    
        }

        public static int IsOutofOrderAscending(IEnumerable<int> source)
        {
            return IsOutofOrder(source, (int x, int y) =>
            {
                if (x <= y) return true;
                else return false;

            });
        }

    }
}
