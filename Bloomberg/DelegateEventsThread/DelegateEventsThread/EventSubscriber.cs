using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace DelegateEventsThread
{

    internal class EventSubscriber : IDisposable
    {
        //Subscriber must contain a reference to their event publisher.
        //whcih means I know you
        private EventPublisher publishertoSubscribeTo;

        public EventSubscriber() { }

        public EventSubscriber(EventPublisher publisher) 
        {
            this.publishertoSubscribeTo = publisher;
        }

        public void Start()
        {
            if(publishertoSubscribeTo != null)
            {
                //Register the event handler reference to the publisheer event handlers
                // WHAT THE DAN FUCK is GOING ON with this fukcing wiring up?
                // GOAL TO LET EVENT PUBLISHER KNOWS ABOUT the SUBSCRIBER EVENTHANDLERS
                //publishertoSubscribeTo.action1Happened += this.publishertoSubscribeTo.action1Happened(Action1CallBack);
                //publishertoSubscribeTo.action2Happened += this.publishertoSubscribeTo.action2Happened(Action2CallBack);
                //this.publishertoSubscribeTo.action1Happened += new ActionHappened(Action1CallBack);
                //this.publishertoSubscribeTo.action2Happened += new ActionHappened(Action2CallBack);

                this.publishertoSubscribeTo.action1Happened += new EventPublisher.ActionHappen(Action1CallBack);
                this.publishertoSubscribeTo.action2Happened += new EventPublisher.ActionHappen(Action2CallBack);
            }

            publishertoSubscribeTo.OnAction1();
            publishertoSubscribeTo.OnAction2();
        }

        //public void BaseActionCallBack(object sender, PubSubEventArgs eventArg)
        //{
        //    string _publisherName = sender.GetType().Name;
        //    Console.WriteLine(String.Format("Publisher Name {0}, message {1}", _publisherName, eventArg.msg));
        //}


        public void Action1CallBack(object sender, PubSubEventArgs arg)
        {
           // BaseActionCallBack(sender, "Action1 received from " + arg);
            string _pubblisherName = sender.GetType().Name;
            Console.WriteLine(String.Format("Publisher Name {0}, message {1}", _pubblisherName, arg));
            Console.Write("Action1 handled by Event Subscriber" + this.GetType().Name);
        }


        public void Action2CallBack(object sender, PubSubEventArgs arg)
        {
            string _pubblisherName = sender.GetType().Name;
            Console.WriteLine(String.Format("Publisher Name {0}, message {1}", _pubblisherName, arg));
            Console.WriteLine("Action2 handled by event subscriber" + this.GetType().Name);
        }

        private bool isdisposed;
        public void dispose(bool isdisposed)
        {
            if (!isdisposed)
            {
                Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            if (this.publishertoSubscribeTo != null)
            {
                //this.publishertoSubscribeTo.action1Happened -= new ActionHappened(Action1CallBack);
                //this.publishertoSubscribeTo.action2Happened -= new ActionHappened(Action2CallBack);
                //GOAL to remove the entry from the dispatcher event from publisher. 
                // Looks like event dispathcer is a object reference hash key?
                this.publishertoSubscribeTo.action1Happened -= new EventPublisher.ActionHappen(Action1CallBack);
                this.publishertoSubscribeTo.action1Happened -= new EventPublisher.ActionHappen(Action2CallBack);
            }
        }
    }
}
