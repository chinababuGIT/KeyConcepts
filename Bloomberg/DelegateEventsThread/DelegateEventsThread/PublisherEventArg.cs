using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace DelegateEventsThread
{
    internal class PubSubEventArgs : EventArgs
    {
        private string _msg;
        public PubSubEventArgs(string msg)
        {
            Contract.Requires(!String.IsNullOrEmpty(msg));
            _msg = String.Copy(msg);
        }

        public string msg { get { return _msg; } }
    }
    
}
