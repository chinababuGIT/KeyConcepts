using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray _stackEmpty = new StackArray(0);
            var _item = _stackEmpty.Pop();
            _stackEmpty.Push(1);
            _item = _stackEmpty.Pop();
            //StackArray _stackNegative = new StackArray(-1);
            StackArray _stackNormal = new StackArray(1);
            var item = _stackEmpty.Pop();
            _stackEmpty.Push(1);
            _item = _stackEmpty.Pop();
            _stackEmpty.Push(2);
            _stackEmpty.Push(3);

            _item = _stackEmpty.Pop();
        }
    }

}

