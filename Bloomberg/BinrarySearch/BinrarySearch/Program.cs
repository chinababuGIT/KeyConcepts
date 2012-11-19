using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinrarySearch
{
    using BinrarySearch;
    class Program
    {
        static void Main(string[] args)
        {
            BinarchSearch bSearch = new BinarchSearch();
            var sourceArray = new int[1]{-1};
            BinarchSearch.BinarySearch(0,sourceArray,0,0);
            sourceArray = new int[5]{1,2,3,4,5};
            BinarchSearch.BinarySearch(1,sourceArray,0,5);
        }
    }
}
