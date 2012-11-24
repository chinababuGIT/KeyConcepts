using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncProcessingDeadSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> additionDel = new Func<int, int, int>(Addition);
            int ret = additionDel.Invoke(1, 2);
            Console.WriteLine("From Sync invoke " + ret);
            object state = new Object();
            IAsyncResult _asyncresult = additionDel.BeginInvoke(1,2,null, null);
            //calling thread blocks until endInvokecompletes
            ret= additionDel.EndInvoke(_asyncresult);
            Console.WriteLine("From Aynsc EndInvoke " + ret);

             _asyncresult = additionDel.BeginInvoke(1, 2, new AsyncCallback(PrintCallBack), null);
            // ret = additionDel.EndInvoke(_asyncresult);
            // Console.WriteLine("From Aynsc EndInvoke On asyncCallback" + ret);

             Thread.Sleep(5000);

        }

        static void PrintCallBack(IAsyncResult result)
        {
            //int ret = (int) result.AsyncState;
            Console.WriteLine("async call back completed");
        }


        static int Addition(int x, int y) 
        {
            Thread.Sleep(5000);
            return x + y;
        }


        static void AddComplete(IAsyncResult result) 
        { 
            
        }
    }
}
