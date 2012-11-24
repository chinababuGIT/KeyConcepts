using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using ThreadingBasics.ThreadingPattern;
using ThreadingBasics.ThreadingDataStructure;

namespace ThreadingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaiscThreadingOperation basicthread= new BaiscThreadingOperation(5);
            //basicthread.Run();
            //basicthread.WaitForThreads();
            //BlockForEver();
            //ConditionalVariableDeadLockDemo();
            //ReadWriteVariable();
            //SendPingPongUsingWaitHandle();
            
            //ThreadsABAlternateWait.AlternateWait();
            //SimpleMultualExclusiong.MultualExclusionUsingMultex();
            //SimpleMultualExclusiong.MultutualExclusionUsingLock();
            //SimpleMultualExclusiong.MultualExclusiongUsingSemaphore();
            //SimpleMultualExclusiong.MultualExclusionUsingMonitor();
            TestMultiplex();
            //SemaphoreMultiplex();
        }

        static void SemaphoreMultiplex() 
        {
            counter = 0;
            Semaphore multiple = new Semaphore(0, 10);
            multiple.Release();
            ConcurrentQueue<int> answer = new ConcurrentQueue<int>();

            //multiple.
            Random ex = new Random();
            Thread[] array = new Thread[50];
            for (int i = 0; i < 50; i++) 
            {
                array[i] = new Thread(
                        () =>
                        {
                            multiple.WaitOne();
                            counter = 1 + counter;
                            Thread.Sleep(ex.Next(67));
                            multiple.Release();
                            answer.Enqueue(counter);
                        }
                    );
                array[i].Start();
               
            }
            foreach (var t in array) 
            {
                t.Join();
            }

            var s = answer.Distinct();
            foreach (var t in answer)
            {
                Console.WriteLine("count {0} and t {1}", t, answer.Count());
            };
        }


        static int counter;
        static void TestMultiplex() 
        {
            counter = 0;
            ThreadMultiplex multiplex = new ThreadMultiplex(100);
            Random exec = new Random();
            Thread[] threadArray = new Thread[1000];
            ConcurrentStack<int> answer = new ConcurrentStack<int>();
            for (int i = 0; i < 1000; i++) 
            {
                int temp = -1;
                threadArray[i] = new Thread(
                        ()=>{
                            multiplex.Enter();
                            Thread.Sleep(exec.Next(576));
                            temp = ++counter;
                            multiplex.Release();
                            Thread.Sleep(exec.Next(146));
                            answer.Push(temp);       
                        }
                    );
                threadArray[i].Start();
                //Console.WriteLine(temp);
            }

            foreach (var t in threadArray) 
            {
                t.Join();
            }

            foreach(var t in answer)
            {
                Console.WriteLine(t);
            }
        }

        static void SendPingPong() 
        {
            PingPongUsingLocks pingPong = new PingPongUsingLocks();
  
        }

        static EventWaitHandle _readyToSendPing = new AutoResetEvent(false);
        static EventWaitHandle _readyToSendPong = new AutoResetEvent(false);
        static void SendPingPongUsingWaitHandle()
        {
            var sendPing = new Thread( ()=>{
                           _readyToSendPing.Set();
                           while(true)
                           {
                               //_readyToSendPong.Set();
                               _readyToSendPong.WaitOne();
                               Console.WriteLine("Send Ping");
                               _readyToSendPing.Set();
                               Thread.Sleep(100);
                           }
                       }
                );
            sendPing.Start();
            var sendPong = new Thread(() =>
                    {
                        while (true)
                        {
                            _readyToSendPing.WaitOne();
                            Console.WriteLine("Send Poing");
                            _readyToSendPong.Set();
                            Thread.Sleep(100);
                        }
                    }
                );
            sendPong.Start();

            sendPing.Join();
            sendPong.Join();
          
        }



        //static void ReadWriteVariable() 
        //{ 
        //    SynchronizationUsingLocks usingLocks = new SynchronizationUsingLocks();
        //    Random randomizer = new Random();
        //    for(int i =0 ;i < 50000; i++)
        //    {
        //        var t = new Thread(()=>{
        //                int ret= usingLocks.ReadVariable();
        //                Console.WriteLine("Value read: " + ret);             
        //            });
        //        t.Start();
        //        var s = new Thread(()=>{
        //                int val = randomizer.Next();
        //                usingLocks.WriteVariable(val);
        //                Console.WriteLine("Val Wrote" + val);
        //            });
        //        s.Start();
        //        t.Join();
        //        s.Join();
        //    }
            

        //}

        static void ConditionalVariableDeadLockDemo() 
        {
            ConditionalVar conditionalVar = new ConditionalVar();
            var threadA = new Thread( ()=> {
                                    conditionalVar.RunIfThreadAHappened();
                                }
                );
            var threadB = new Thread(() =>
            {
                conditionalVar.RunIfThreadBHappened();
            });
            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            
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
