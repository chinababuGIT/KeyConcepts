using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaiscThreadingOperation basicthread= new BaiscThreadingOperation(5);
            //basicthread.Run();
            //basicthread.WaitForThreads();
            BlockForEver();

     
        }

        static void BlockForEver()
        {
            bool complete = false;
            var t = new Thread(()=>
                                   {
                                       bool toggle = false;
                                       while (!complete) toggle = !toggle;
                                   }
                );
            t.Start();
            Thread.Sleep(1000);
            complete = true;
            t.Join();

        }
    }
}
