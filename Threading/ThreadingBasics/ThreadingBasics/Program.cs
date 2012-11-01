using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ThreadingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            BaiscThreadingOperation basicthread= new BaiscThreadingOperation(5);
            basicthread.Run();
            basicthread.WaitForThreads();
        }
    }
}
