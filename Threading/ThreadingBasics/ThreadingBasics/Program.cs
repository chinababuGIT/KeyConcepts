using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using ThreadingBasics.ThreadingPattern;
using ThreadingBasics.ThreadingDataStructure;
using ThreadingBasics.StatefulCalculator;

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
            //TestMultiplex();
            //SemaphoreMultiplex();
            AsyncCalculator calculator = new AsyncCalculator();
            calculator.Run();
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

        //static bool WriteFileContentCalBack(byte[] buffer, IAsyncResult result)
        //{
        //    bool ret = false;
        //    FileAsyncWriteResult _fileWriteResult = result as FileAsyncWriteResult;
        //    if(_fileWriteResult!=null)
        //    {
        //        Func<byte[], bool> writeDelegate = _fileWriteResult.Del as Func<byte[], bool>;
        //        writeDelegate.EndInvoke(result);
        //        ret = true;
        //    }

        //    return ret;
        //}

        //static void CallFileStreamReadWriter() 
        //{
        //    using (FileStreamReadWriter fsRW = new FileStreamReadWriter(@"C:\\temp\\NEInstX64")) 
        //    {
        //        string msg = "thsi is s test";
        //        byte[] writeBuffer = Encoding.ASCII.GetBytes(msg);

            
            
        //    }; 
        //}
    }

    //internal class FileAsyncWriteResult : IDisposable, IAsyncResult 
    //{
    //   // delegate Func<byte[], bool> writeFileContent ;


    //    Func<byte[], bool> _asyncCallback;
    //    Object _state;

    //    public FileAsyncWriteResult(AsyncCallback callback, Object state)
    //    {
    //        this._asyncCallback = callback as Func<byte[],bool>;
    //        this._state = state;
    //    }

    //    public AsyncCallback Del { get{return _asyncCallback;}}
       

    //    private bool isDisposed;

    //    private void Dispose(bool disposing)
    //    {
    //        if (!isDisposed) 
    //        {
    //            if (!disposing) 
    //            { 
                    
    //            }
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    public object AsyncState
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public WaitHandle AsyncWaitHandle
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public bool CompletedSynchronously
    //    {
    //        get { return false; }
    //    }

    //    public bool IsCompleted
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}

    //internal class FileAsyncReadResult : IDisposable, IAsyncResult 
    //{
    //   // delegate Func<byte[]> readFileContent;
    //    Func<bool> _readCalback;
    //    Object _asyncState;

    //    public FileAsyncReadResult(AsyncCallback  readCallBack, object state)
    //    {
    //        this._readCalback = readCallBack;
    //        this._asyncState = state;
    //    }


    //    private bool isDisposed;
    //    private void Dispose(bool disposing)
    //    {
    //        if (!isDisposed) 
    //        {
    //            if (!disposing) 
    //            { 
                    
    //            }
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    public object AsyncState
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public WaitHandle AsyncWaitHandle
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //    public bool CompletedSynchronously
    //    {
    //        get { return false; }
    //    }

    //    public bool IsCompleted
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}

    //internal class FileStreamReadWriter :IDisposable
    //{
    //    private FileStream fileStreamRW;
    //    private bool isDisposed;

    //    public FileStreamReadWriter(String filename) 
    //    {
    //        if (!String.IsNullOrEmpty(filename.Trim())) 
    //        {
    //            fileStreamRW = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);                
    //        }
    //    }

    //    public bool WriteToFileWithContent(byte[] someDataBuffer)
    //    {
    //       // Func<byte[], bool> writeDelegate = ()=>
    //       //                                          {
                                                     
    //       //                                          };
    //       //// IAsyncResult result= new object
    //        IAsyncResult FileAsyncWriteResult = new FileAsyncWriteResult();
    //        return false;
        
    //    }

    //    public bool ReadContentFromFile() 
    //    {

    //        return false;
    //    }


    //    public void Dispose(bool disposing) 
    //    {
    //        if(!isDisposed)
    //        {
    //            if (disposing) 
    //            {
    //                //clean up managed resource
    //                fileStreamRW.Dispose();            
    //            }
    //            //No unmanaged resource here.
    //        }
    //        isDisposed = true;
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    ~FileStreamReadWriter() 
    //    {
    //        //Cleaning up unmanaged resource only
    //        Dispose(false);
    //    }
    //}
}
