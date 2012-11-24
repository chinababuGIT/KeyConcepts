using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingBasics.StatefulCalculator
{

    //internal class ComputationAsyncResult : IAsyncResult 
    //{

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
    //        get { }
    //    }

    //    public bool IsCompleted
    //    {
    //        get {  }
    //    }
    //}

    //public delegate float Func<float, float, float>(float right, float left);
    //public delegate float Func<float, float>(float operand);

    internal class AsyncState 
    {
        public AsyncState(Delegate del, object state) 
        {
            this._delegateFunc = del;
            this._state = state;
        }
        public Delegate _delegateFunc { get; private set; }
        public object _state { get; private set; }
    
    }

    internal class AsyncCalculator
    {
        Random runlength = new Random();

        //public IAsyncResult AddAsync(AsyncIOCompletion

        void GetBinaryOperationCallback(IAsyncResult result)
        {
            var asyncState = result.AsyncState as AsyncState;
            var del = asyncState._delegateFunc as Func<float,float,float>;
            var ret  = del.EndInvoke(result);
            Console.WriteLine("Result" + ret);
        }

        void GetUniaryOperationCallback(IAsyncResult result)
        {
            var asyncState = result.AsyncState as AsyncState;
            var del = asyncState._delegateFunc as Func<float,float>;
            var ret = del.EndInvoke(result);
            Console.WriteLine("Result" + ret);
        }


        public void Run()
        {
            
            while(true)
            {
                String key = Console.ReadLine(); 
                float right = 1.0F;
                float left = 2.0F;
                float ret;
                key = key.Trim().ToLower();
                if (key.CompareTo("a") ==0)
                { 
                    //IAsyncResult result = new Asyn
                    //BeginAdditon(right,left,GetBinaryOperationCallback,state);
                    //ret = EndAddition();
                }
                if(key.CompareTo("d")==0)
                {
                }
                if(key.CompareTo("n")==0)
                {
                }
                if(key.CompareTo("s")==0)
                {
                }
                if(key.CompareTo("m")==0)
                {
                }
                    
            }
        }
#region AsyncOperation
        //public delegate float Func<float,float,float>(float right, float left);
        //public delegate float Func<float,float>(float operand);

        public IAsyncResult BeginAdditon(float right, float left, AsyncCallback computeCallBack, object state)
        {
            Func<float,float,float> addition = new Func<float,float,float>(this.Add);
            AsyncState asyncState = new AsyncState(addition, state);
            return addition.BeginInvoke(right, left, computeCallBack, asyncState);
            
        }
        
        public float EndAddition(IAsyncResult result)
        {
            //float ret = (float)result.AsyncState;
            AsyncState asyncState = result.AsyncState as AsyncState;
            Func<float, float, float> addition = asyncState._delegateFunc as Func<float,float,float>;
            float ret = addition.EndInvoke(result);
            Console.WriteLine("Add result: " + ret);
            return ret;
        }


        public IAsyncResult BeginSubtraction(float right, float left, AsyncCallback computeCallBack, object state)
        {
            Func<float, float, float> subtraction = new Func<float, float, float>(this.Subtract);
            AsyncState asyncState = new AsyncState(subtraction, state);
            return subtraction.BeginInvoke(right, left, computeCallBack, asyncState);
        }

        public float EndSubtraction(IAsyncResult result)
        {
            AsyncState asyncState = result.AsyncState as AsyncState;
            Func<float, float, float> substraction = asyncState._delegateFunc as Func<float,float,float>;
            float ret = substraction.EndInvoke(result);
            //float ret = (float) result.AsyncState;
            Console.WriteLine("Substraction result" + ret);
            return ret;
        }

        public IAsyncResult BeginMultiplication(float right, float left, AsyncCallback computeCallBack, object state)
        {
            Func<float, float, float> multiplication = new Func<float, float, float>(this.Multiply);
            AsyncState asyncState = new AsyncState(multiplication, state);
            return multiplication.BeginInvoke(right, left, computeCallBack, asyncState);
        }

        public float EndMultiplication(IAsyncResult result)
        {
            //float ret = (float)result.AsyncState;
            AsyncState asyncState = result.AsyncState as AsyncState;
            Func<float, float, float> multiplication = asyncState._delegateFunc as Func<float,float,float>;
            float ret = multiplication.EndInvoke(result);
            Console.WriteLine("Multiple result " + ret);
            return ret;
        }

        public IAsyncResult BeginDivision(float right, float left, AsyncCallback computeCallBack, object state)
        {
            Func<float, float, float> division = new Func<float, float, float>(this.Division);
            AsyncState asyncState = new AsyncState(division, state);
            return division.BeginInvoke(right, left, computeCallBack, asyncState);
        }

        public float EndDivision(IAsyncResult result)
        {
            //float ret = (float)result.AsyncState;
            AsyncState state = result.AsyncState as AsyncState;
            Func<float, float, float> division = state._delegateFunc as Func<float,float,float>;
            float ret = division.EndInvoke(result);
            Console.WriteLine("Division result " + ret);
            return ret;
        }

        public IAsyncResult BeginNegation(float operand, AsyncCallback computeCallback, object state)
        {
            Func<float, float> negation = new Func<float, float>(this.Negative);
            AsyncState asyncState = new AsyncState(negation, state);
            return negation.BeginInvoke(operand,computeCallback, asyncState);
        }

        public float EndNegation(IAsyncResult result)
        {
            //float ret = (float)result.AsyncState;
            AsyncState asyncState = result.AsyncState as AsyncState;
            Func<float, float> negation = asyncState._delegateFunc as Func<float, float>;
            float ret = negation.EndInvoke(result);
            Console.WriteLine("Negation result " + ret);
            return ret;
        }

#endregion

#region SyncCalls
        private float Add(float right, float left)
        {
            RandomSleep(388);
            Console.WriteLine("Lengthy addition");
            return (right + left);
        }

        private float Multiply(float right, float left)
        {
            RandomSleep(468);
            Console.WriteLine("Lengthy multiplication");
            return (right * left);
        }

        private float Division(float right, float left)
        {
            RandomSleep(678);
            Console.WriteLine("Lengthy division");
            return (right / left);
        }

        private float Subtract(float right, float left)
        {
            RandomSleep(158);
            Console.WriteLine("Lengthy subtracton");
            return (right - left);
        }

        private float Negative(float operand) 
        {
            RandomSleep(118);
            Console.WriteLine("Lengthy negation");
            return -operand;
        }
#endregion
       
        void RandomSleep(int maxSec) 
        { 
            Thread.Sleep(runlength.Next(maxSec));
        }

    }

}
