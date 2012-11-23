using System;
using System.Threading;

namespace ThreadingBasics
{
    // Semphore is a signalling construct such that 
    // - when initialized to a positive integer number, that is capacity it can allow signal
    // - A thread waiting on that that semoaphore will decerment the count 
    // - when a thread account goes below zero, it blocks itself
    // - when a thread release the semaphore, count increment and some other blocked thread goes into waiting

    public class MySemaphore
    {
        private int count;


    }


    public class MySemphoreFromAPM
    {
    
    }

}
