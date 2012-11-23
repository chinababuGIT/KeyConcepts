using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics.Contracts;

namespace ThreadingBasics.AsyncIOCompletion
{
    internal class AsyncSearchClientResult: IAsyncResult, IDisposable
    {

        ManualResetEventSlim waitHandle;

       // public AsyncSearchClientResult(AsyncCallback callBack, 
        
        //private object padLock = new object();


        #region DisposalOfResource
        private bool isDisposed;

        public bool Dispose() {

            GC.SuppressFinalize(this);
            return true;
        }


        public bool Dispose(bool toDispose) 
        {
            //lock (padLock) 
            //{ 
            if (!isDisposed)
            {
                Dispose();

            }
            return true;
        }

        #endregion

        public object AsyncState
        {
            get { throw new NotImplementedException(); }
        }

        public WaitHandle AsyncWaitHandle
        {
            get { throw new NotImplementedException(); }
        }

        public bool CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
