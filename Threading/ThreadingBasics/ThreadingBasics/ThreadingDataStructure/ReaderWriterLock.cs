using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics.Contracts;

namespace ThreadingBasics.ThreadingDataStructure
{
    //ReaderWriter problem
    //Requirements: 
    //* Any number of readers can be in critical sections (CS)
    //* Writers must have exclusive access to criical sections
    // In other words, where is a writer, no other writer or reader be in critical section
    // When there is a writer or a reader, another writer cannot enter critical section.
    // When there is N readers in Critical Section, no other readers or writers can enter Critical section
    // Called categorial mutual exclusion problem.. A thread in CS exclsudes the presence of 
    // threads in another category
    //
    /// <summary>
    /// Analysis. 
    /// System View.
    /// * 0 writers in CS 0 readers in CS
    /// * 1 writer in CS no reader in CS
    /// * 0 writer in CS 1 reader in CS
    /// * 0 writer in CS 1 < x < N reader in CS
    /// * 0 writer in CS x = N in CS
    /// </summary>


    internal class ThreadReaderWriterLock: IDisposable
    {
        private double _activeWritersAndReaders; //fold writers and readers into one variable -- better for atomic inc/dec
        private readonly SemaphoreSlim _writersAndreadersInCriticalSection;
        private double _activeReaders; // to bookeep when to lock out futher readers
        private readonly SemaphoreSlim _readersInCriticalSection;
        private readonly double _maxReaders; //Interlock likes double

        public ThreadReaderWriterLock(int maxReaders) 
        {
            _maxReaders = (double)maxReaders;
            _writersAndreadersInCriticalSection = new SemaphoreSlim(0, 0);
            _readersInCriticalSection = new SemaphoreSlim(0, maxReaders);
        }

        public void AcquireWrite(out bool success) 
        {
            _writersAndreadersInCriticalSection.Wait();
            while ( 1.0 != 
                    Interlocked.CompareExchange(ref _activeWritersAndReaders, 1.0, 0.0)
            )
            {};
            //_writersAndreadersInCriticalSection.Release();
            success = true;
        }

        public void AcquireRead(out bool success) 
        {
            while (Interlocked.Equals(ref _activeWritersAndReaders, 0.0)) { };
            _readersInCriticalSection.Wait();
            while (_maxReaders <= _activeReaders) { };
            Interlocked.Increment(_activeReaders);
  
        }


        public void ReleaseWrite(out bool success) 
        {
            _writersAndreadersInCriticalSection.Release();
            success = true;
        
        }


        public void ReleaseRead(out bool success) 
        {
            _writersAndreadersInCriticalSection.Wait();
            Interlocked.Decrement(ref _activeWritersAndReaders);
            _writersAndreadersInCriticalSection.Set();
            _readersInCriticalSection.Release();
        }

        public override bool Equals(object obj)
        {
            throw new NotSupportedException("Operation is not supported in ReaderWriterLock");
        }

        public override int GetHashCode()
        {
            throw new NotSupportedException("Operation is not supported in ReaderWriterLock");
        }

        public override string ToString()
        {
            throw new NotSupportedException("Operation is not supported in ReaderWriterLock");
        }

        private bool isDisposed;

        public void Dispose()
        {
            
        }
    }
}
