using System;
using System.Threading;

namespace ThreadingBasics.ThreadingDataStructure
{
    internal static class ThreadsABAlternateWait
    {
        static SemaphoreSlim a1Arrived = new SemaphoreSlim(0);
        static SemaphoreSlim b1Arrived = new SemaphoreSlim(0);

        //Write A Two-way singalling such that ThreadA (2-steps a1,a2) and ThreadB (b1,b2)
        //gurantee that a1>b2; b1>a2.

        public static void AlternateWait() 
        {
            Random ran= new Random();
            for (int i = 0; i < 100; ++i)
            {

                var threadA = new Thread(
                        () => RunThreadA()
                    );
                var threadB = new Thread(
                        () => RunThreadB()
                    );
                Thread.Sleep(ran.Next(761));
                threadB.Start();
                Thread.Sleep(ran.Next(131));
                threadA.Start();

                //threadA.Join();
                //threadB.Join();
                Console.WriteLine();
            }
        
        }
        static Random randomizeExectionTime = new Random();
        static void RunThreadA() 
        {
            Console.WriteLine("A1 Done");

            Thread.Sleep(randomizeExectionTime.Next(997));
            a1Arrived.Release();
            Thread.Sleep(randomizeExectionTime.Next(11));
            b1Arrived.Wait();
            Thread.Sleep(randomizeExectionTime.Next(467));
            Console.WriteLine("A2 Done");
        }


        static void RunThreadB() 
        {
            Thread.Sleep(randomizeExectionTime.Next(117));
            Console.WriteLine("B1 Done");
            b1Arrived.Release();
            a1Arrived.Wait();
            Thread.Sleep(randomizeExectionTime.Next(239));
            Console.WriteLine("B2 Done");
        }
    }
}
