using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics
{
    internal class ConditionalVar
    {
        static int threadAHappened = -1;
        static int threadBHappened = -1;
        enum ThreadSignal
        {
            ThreadAHappened = 1,
            ThreadBHappened = 2
        };

        public void RunIfThreadBHappened() 
        {
            while ((int)ThreadSignal.ThreadBHappened != Interlocked.CompareExchange(ref threadAHappened, 
                                              (int)ThreadSignal.ThreadAHappened, 
                                              (int)ThreadSignal.ThreadBHappened))
            {
                Console.WriteLine("Thread B Not happened, now waiting ");
                Thread.Sleep(1000);           
            }
                                          
        }

        public void RunIfThreadAHappened()
        {
            while ((int)ThreadSignal.ThreadAHappened != Interlocked.CompareExchange(ref threadAHappened,
                                              (int)ThreadSignal.ThreadBHappened,
                                              (int)ThreadSignal.ThreadAHappened))
            {
                Console.WriteLine("Thread A not happened, now waiting");
                Thread.Sleep(1000);
            }

        }

    }


}
