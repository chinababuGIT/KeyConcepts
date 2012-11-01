using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingBasics
{
    internal class BaiscThreadingOperation
    {

        readonly int _threadsToCreate;
        delegate void PrintTask(string message);

        internal BaiscThreadingOperation(int threadToCreate)
        {
            _threadsToCreate = threadToCreate;
        }

        internal void OnExecute(string message)
        {
            Console.WriteLine();
            Console.Write("current thread created {0} threadId {1}, message {2}", _threadsToCreate,Thread.CurrentThread.ManagedThreadId, message);
            Console.WriteLine();
        }


        internal void Run()
        {
           for(int i = 0 ;i < _threadsToCreate; i++)
            {
                Thread thread = new Thread(() =>
                {
                    OnExecute("start thread");
                });
                thread.Start(); 
            }
        }

        internal void RunLamda() 
        { 
            for(int i =0; i < _threadsToCreate; i++)
            {
                Thread thread = new Thread(() => OnExecute("wawawaw"));
                thread.Start();

               
            }

            
        
        }

        internal void RunTask() 
        {
            //PrintTask = OnExecute("blarblar");
            //for (int i = 0; i < _threadsToCreate; i++)
            //{ 
            //    Action action = new Action(PrintTask);
            //    Thread threada = new Thread(action).Start;
            //}
        }

        internal void WaitForThreads() 
        {
            for (int i = 0; i <= _threadsToCreate; i++)
            {
                Thread thread = new Thread(() => OnExecute("waitfor threads"));
                thread.Start();
                thread.Join();
                Console.WriteLine("Current threadId {0} counter {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
            
        }

    }
}
