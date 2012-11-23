using System;
using System.Collections.Generic;
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
            SimpleMultualExclusiong.MultualExclusionUsingMultex();
            //SimpleMultualExclusiong.MultutualExclusionUsingLock();
            SimpleMultualExclusiong.MultualExclusiongUsingSemaphore();
            SimpleMultualExclusiong.MultualExclusionUsingMonitor();
        }

        static void SendPingPong() 
        {
            PingPongUsingLocks pingPong = new PingPongUsingLocks();
            //while (true)
            ////{
            //    var ping = new Thread(

            //        );
            //    ping.Start();
            //    var pong = new Thread(

            //        );
            //    pong.Start();
            ////}
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
