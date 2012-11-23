using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics.ThreadingPattern
{
   // internal class SynchronizationUsingLocks

    //internal 
        
    class PingPongUsingLocks
    {
        bool readyToSendPong;
        object padLockSendPong = new object();

        bool readyToSendPing;
        object padLockSendPing = new object();

        public void SendPing()
        {
            bool localVar = false; ;
            lock(padLockSendPing)
            {
               //readyToSendPong
               
            }
            Console.WriteLine("SendPing " + localVar);
        }

        public void SendPoing()
        {
            bool localVar =false;
            lock(padLockSendPong)
            {
                readyToSendPing = true;
            }
            Console.WriteLine("SendPong " + localVar);
        }


            
    }

    internal class SynchronizationUsingMultex
    {
        object syncLock = new object();
        
        static int shareVariable;

        public int ReadVariable()
        {
           // (var mutex = new Mutex(
            lock (syncLock)
            {
                return shareVariable;
            }
        }

        public void WriteVariable(int value)
        {
            lock (syncLock)
            {
                shareVariable = value;
            }
        }

    }
}
