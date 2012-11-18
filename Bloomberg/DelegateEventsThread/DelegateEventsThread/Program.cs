using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEventsThread
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber(publisher);
            subscriber.Start();
           
            ////Wiring up the subscriber and publisher relationship
            // You cannot do it here
            //publisher.action1Happened += subscriber.Action1CallBack(publisher, "Action1 handled by subscriber");
            //publisher.action2Happened += subscriber.Action2CallBack(publisher, "Action2 handled by subscriber");

            //publisher.action1Happened -= subscriber.Action1CallBack(publisher, "Action1 handled by subscriber");
            //publisher.action2Happened -= subscriber.Action2CallBack(publisher, "Action2 handled by subscriber");

        }
    }
}
