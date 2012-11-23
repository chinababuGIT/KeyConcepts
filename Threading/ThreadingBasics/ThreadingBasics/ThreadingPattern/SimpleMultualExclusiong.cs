using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading;

namespace ThreadingBasics.ThreadingPattern
{
    public class SimpleMultualExclusiong
    {
        static int count;
        static Random executionLengthRadomizer = new Random();
        static ConcurrentStack<int> answer = new ConcurrentStack<int>();

        public static void MultualExclusionUsingMultex() 
        {
            Mutex writeMultex = new Mutex(false, "MultexSimpleCountingExample");
            answer.Clear();
            count = 0;
            for (int i = 0; i < 1000; ++i)      
            {
                var writeThread = new Thread(
                        () => {
                            writeMultex.WaitOne();
                            var result = WriteThread(executionLengthRadomizer);
                            writeMultex.ReleaseMutex();
                            //throw new Exception();
                            answer.Push(result);
                        }
                    );
                writeThread.Start();
               // writeThread.Join();                
            }

            foreach(var item in answer){
                Console.WriteLine(item);
            }
        }

        static int WriteThread(Random executionLengthRand) 
        {
            executionLengthRand.Next(697);
            count = count + 1;
            executionLengthRand.Next(1937);
            return count;
        }

        public static void MultualExclusiongUsingSemaphore() {
            count = 0;
            Semaphore writeSem = new Semaphore(1, 1);
            answer.Clear();
            Random executionLengthRand = new Random();
            for (int i = 0; i < 1000; i++) 
            {
                var t = new Thread(
                        () =>
                        {
                            int temp = -1;
                            executionLengthRand.Next(697);
                            writeSem.WaitOne();
                            count = count + 1;
                            temp = count;
                            executionLengthRand.Next(1937);
                            writeSem.Release();
                            answer.Push(temp);
                        }
                    );

                t.Start();
            }
            foreach (var item in answer.Reverse()) 
            {
                Console.WriteLine(item);
            }
        }

        public static void MultualExclusionUsingMonitor()
        {
            count = 0;
            object writeLock = new object();
            var lockSuccess = Monitor.TryEnter(writeLock);
            answer.Clear();
            Random executionLengthRand = new Random();
            for (int i = 0; i < 1000; ++i) { 
                var t = new Thread
                    (
                        ()=>{
                            int temp =-1;
                             executionLengthRand.Next(697);
                            Monitor.Wait(writeLock);
                            temp= count++;
                             executionLengthRand.Next(997);
                            Monitor.PulseAll(writeLock);
                            answer.Push(temp);
                        }
 
                    );
            
                t.Start();
            }   


            foreach(var item in answer.Reverse()){
                Console.WriteLine(item);
            }
        
        
        
        }


        public static void MultutualExclusionUsingLock() 
        {
            count = 0;
            object writeLock = new object();
            answer.Clear();
            Random executionLengthRand = new Random();
            for (int i = 0; i < 1000; ++i)
            {
                var t = new Thread(
                        () => 
                        {
                            int temp  = -1;
                            lock (writeLock) 
                            {
                                executionLengthRand.Next(1937);
                                ++count;
                                executionLengthRand.Next(537);
                                temp = count;
                            }
                            answer.Push(temp);
                        }
                    );
                t.Start();
            }

            foreach (var item in answer.Reverse()) 
            {
                Console.WriteLine(item);
            }
            
        }

        public static void MutualExclusionUsingWitHandle() { }

    }
}
