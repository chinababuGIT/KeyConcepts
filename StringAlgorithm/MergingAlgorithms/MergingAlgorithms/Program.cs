using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> thisList = new List<int>() {};
            IList<int> thatList = new List<int>() {};
            var result = MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("empty list ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine("empty list  recurse");
            result = MergeList.Merge2Lists(thisList, thatList, true);
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine("empty list  recurse");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            thisList = null;
            thatList = null;
            result = MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("null lists");
            if(result!=null)
                foreach(var t in result)
                      Console.Write(t);
            Console.WriteLine();
            result = MergeList.Merge2Lists(thisList, thatList, true);
            Console.WriteLine("null lists recurse");
            if (result != null)
                foreach (var t in result)
                    Console.Write(t);
            Console.WriteLine();
            thisList = null;
            thisList = new List<int>() { 1 };
            thatList = null;
            thatList = new List<int> { 3, 5, 6, 9 };
            result = MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("this list 1 elemtn, other 4 elem ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine();
            result = MergeList.Merge2Lists(thisList, thatList, true);
            Console.WriteLine("this list 1 elemtn, other 4 elem  recurse ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine();
            result = null;
            thisList = null;
            thisList = new List<int>() { 1,2,3,4,5,6,7};
            thatList = null;
            thatList = new List<int> { 3, 5, 6, 9 };
            result = MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("thislsit longer than thatlist");
            foreach (var t in result)
            {
                Console.Write(t);
            };
            Console.WriteLine();
            Console.WriteLine("thislsit longer than thatlist recurse");
           result = MergeList.Merge2Lists(thisList, thatList, true);
          
           foreach (var t in result)
            {
                Console.Write(t);
            };
            Console.WriteLine();

            thisList = null;
            thisList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            thatList = null;
            thatList = new List<int> { 8, 9, 10, 11 };
            result = MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("that list longer sorted concat ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine();
            result = MergeList.Merge2Lists(thisList, thatList, true);
            Console.WriteLine("that list longer  sorted concat recurse ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine();

            thisList = null;
            thisList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            thatList = null;
            thatList = new List<int> { 3, 5, 6, 9, 10, 11, 12};
            result =  MergeList.Merge2Lists(thisList, thatList, false);
            Console.WriteLine("same length ");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            result = MergeList.Merge2Lists(thisList, thatList, true);
            Console.WriteLine("same length recurse");
            foreach (var t in result)
            {
                Console.Write(t);
            }
            Console.WriteLine();

        }
    }
}
