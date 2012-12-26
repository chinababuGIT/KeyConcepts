using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackArray
    {
        int capacity;
        int top;
        int[] _dataStack;
        public StackArray(int size)
        {
            Contract.Requires(size > 0);
            Contract.Ensures(capacity > -1);
            //if (size > 0)
            //{
                capacity = size;
                top = 0;
                _dataStack = new int[capacity];
            //}
        
        }

        public int Pop()
        {
            Contract.Ensures(top >= 0);
            int result = int.MinValue;
            if (!isStackEmpty())
            {
                result = _dataStack[top];
                --top;

            }
            return result;
        }


        public void Push(int data)
        {
            Contract.Ensures(top >= 0);
            if (!isStackFull())
            {
                ++top;
                _dataStack[top] = data;
            }
        }

        [Pure]
        private bool isStackFull()
        {      
            return !(top <= capacity);
        }

        [Pure]
        private bool isStackEmpty()
        {
            return (top == 0);
        }

        

    }
}
