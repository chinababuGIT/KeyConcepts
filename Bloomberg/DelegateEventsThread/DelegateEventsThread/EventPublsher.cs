using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace DelegateEventsThread
{
    //Publish the events signaturefor boths ubscriber and publisher to use
    //Common protocol data format
    //internal delegate void ActionHappened(object sender, EventArgs arguments);

    internal class EventPublisher
    {
        //Publish the events
         public delegate void ActionHappen(object sender, PubSubEventArgs arguments);

#region A Set of Valid EventsPusblished For Subscription
        public event ActionHappen action1Happened;
        public event ActionHappen  action2Happened;
#endregion

        public EventPublisher()
        {    
        }

        #region This is what the event publisher do on event generation

        //private void IssueEvent(EventArgs args) 
        //{
        //    return new ActionHappened(this, args);
        //}

        public void OnAction1()
        {
            if (this.action1Happened != null) 
            {
                //this.action1Happened += IssueEvent(new PubSubEventArgs("Action1 happened from sender"));
                this.action1Happened(this, new PubSubEventArgs("Action1 happened in publisher"));
            }
        }


        public void OnAction2()
        {
            if (this.action2Happened != null) 
            { 
                //this.action2Happened += IssueEvent(new PubSubEventArgs("Action2 happened from sender"));
                this.action2Happened(this, new PubSubEventArgs("Action2 happened in publisher"));
            }

        }
        #endregion
    }

}
