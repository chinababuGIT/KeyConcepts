using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingAlgorithms
{
    internal static class MergeList
    {
        public static IList<int> Merge2Lists(IList<int> thisList, IList<int> thatList, bool useRecurssion) 
        {
            if (thisList == null && thatList == null)
                return null;
            if (thisList == null)
                return thatList;
            if (thatList == null)
                return thatList;
            if (useRecurssion)
                return Merge2ListsImpl(thisList, thatList);
            else
            {
                var thisListLength = thisList.Count();
                var thatListLength = thatList.Count();
                var maxCount = thisListLength + thatListLength;
                var result = new List<int>(maxCount);
                return Merge2ListRecurseImple(thisList, thatList, 0, 0, thisListLength, thatListLength, result);
            }

        }

        private static IList<int> Merge2ListsImpl(IList<int> thisList, IList<int> thatList) 
        {
            Contract.Requires(thisList != null && thatList != null);
            int i = 0;
            int j = 0;

            int thisListLength = thisList.Count();
            int thatListLength = thatList.Count();
            //Case: Assuming zero based indexing.
            // - 2 list of same length <<most specific condition>>
            // - thisList is longer  <<less so>>
            // - thatList is longer <<less so>>
            int maxLength = thisListLength + thatListLength;
            IList<int> result = new List<int>(maxLength);
            
            while (i <= thisListLength && j <= thatListLength)
            {

                if (i == thisListLength )
                {
                    result = result.Concat(thatList).ToList();
                    break;
                }
                if (j == thatListLength )
                {
                    result = result.Concat(thisList).ToList();
                    break;
                }

                //the global minimal will be one of the first elemenentsr
                if (i < thisListLength && j < thatListLength)
                if ((thisList[i] > thatList[j]))
                {
                    result.Add(thatList[i]);
                    ++j;
                }
                else
                {
                    result.Add(thisList[i]);
                    ++i;
                }

                //if (i == thisListLength)
                //{
                //    result = result.Concat(thatList).ToList();
                //    break;
                //}
                //if (j == thatListLength)
                //{
                //    result = result.Concat(thisList).ToList();
                //    break;
                //}
            }

            //if (i == thisListLength)
            //    result = result.Concat(thatList).ToList();
            //if (j == thatListLength)
            //    result = result.Concat(thisList).ToList();
            Contract.Ensures(result != null);
            return result;
        }

        private static IList<int> Merge2ListRecurseImple(IList<int> thisList, IList<int> thatList,
                                                          int thisCounter, int thatCounter,
                                                          int thisLength, int thatLength,
                                                          IList<int> result) 
        {
            Contract.Requires(thisList != null && thatList != null);
            //Base Case
            //Do nothing when reaches end of lists
            if (thisCounter == thisLength
                && thatCounter == thatLength)
                return result;

            if (thisCounter < thisLength && thatCounter < thatLength)
            {
                if (thisList[thisCounter] > thatList[thatCounter])
                {
                    result.Add(thatList[thatCounter]);
                    ++thatCounter;
                }
                else
                {
                    result.Add(thisList[thisCounter]);
                    ++thisCounter;
                }
            }

            if (thisCounter == thisLength)
            {
                result = result.Concat(thatList).ToList();
                return result;
            }
            if (thatCounter == thatLength)
            {
                result = result.Concat(thisList).ToList();
                return result;
            }
            Contract.Ensures(result != null);
            return Merge2ListRecurseImple(thisList, thatList, thisCounter, thatCounter, thisLength, thatLength, result);
        }

    }
}
