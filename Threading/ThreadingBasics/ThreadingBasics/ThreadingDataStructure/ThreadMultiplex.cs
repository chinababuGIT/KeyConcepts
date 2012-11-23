using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadingBasics.ThreadingDataStructure
{
    //Multiplex enforces n positve number of threads
    //in cricitcal section
    public sealed class ThreadMultiplex
    {
        int numberOfThreads;
        int threadsInCS;
        ManualResetEvent isRoomFull = new ManualResetEvent(false);
        AutoResetEvent changeThreadNumber = new AutoResetEvent(true);

        public ThreadMultiplex(int threadNo)
        {
            numberOfThreads = threadNo > 0 ? threadNo: 0;
        }

        public bool Enter()
        {
                changeThreadNumber.WaitOne();
                if (threadsInCS <= numberOfThreads)
                {
                    ++threadsInCS;
                    changeThreadNumber.Set();
                    return isRoomFull.Set();
                }
                else
                {
                    isRoomFull.WaitOne();
                    return false;
                }
        }

        public void Release()
        {
            changeThreadNumber.WaitOne();
            --threadsInCS;
            changeThreadNumber.Set();
            isRoomFull.Set();    
        }

        public bool roomFull()
        {
            return (threadsInCS >= numberOfThreads);
        }

    }
}
