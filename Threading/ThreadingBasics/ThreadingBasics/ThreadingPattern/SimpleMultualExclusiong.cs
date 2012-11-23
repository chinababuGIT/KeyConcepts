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
            Thread[] threadArray = new Thread[1000];
            for (int i = 0; i < 1000; ++i)      
            {
                threadArray[i] = new Thread(
                        () => {
                            writeMultex.WaitOne();
                            var result = WriteThread(executionLengthRadomizer);
                            writeMultex.ReleaseMutex();
                            //throw new Exception();
                            answer.Push(result);
                        }
                    );
                threadArray[i].Start();
               // writeThread.Join();                
            }

            foreach (var t in threadArray)
            {
                t.Join();
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
            Thread[] threadArray = new Thread[1000];
            for (int i = 0; i < 1000; i++) 
            {
                threadArray[i] = new Thread(
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

                threadArray[i].Start();
            }

            foreach (var t in threadArray)
            {
                t.Join();
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
            answer.Clear();
            //var lockSuccess = Monitor.TryEnter(writeLock);
            //answer.Clear();
            Random executionLengthRand = new Random();
            Thread[] threadArray = new Thread[1000];
            //var lockSuccess = Monitor.TryEnter(writeLock);
            for (int i = 0; i < 1000; ++i) {
                threadArray[i] = new Thread
                    (
                        ()=>{
                            int temp =-1;
                            Monitor.TryEnter(writeLock);
                            try
                            {
                                executionLengthRand.Next(697);
                                temp = count++;
                                executionLengthRand.Next(997);
                            }
                            finally
                            {
                                Monitor.Exit(writeLock);
                            }
                            answer.Push(temp);
                        }
 
                    );
            
                threadArray[i].Start();
            }

            foreach (var t in threadArray)
            {
                t.Join();
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
            Thread[] threadArray = new Thread[1000];
            for (int i = 0; i < 1000; ++i)
            {
                threadArray[i] = new Thread(
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
                threadArray[i].Start();
            }


            foreach (var t in threadArray) 
            {
                t.Join();
            }

            foreach (var item in answer.Reverse()) 
            {
                Console.WriteLine(item);
            }
            
        }

        public static void MutualExclusionUsingWitHandle() { }

    }
}
