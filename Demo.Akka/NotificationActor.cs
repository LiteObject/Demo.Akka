using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Akka
{
    public class NotificationActor : UntypedActor
    {
        private IEmailNotification emailNotification;

        public NotificationActor(IEmailNotification emailNotification) 
        { 
            this.emailNotification = emailNotification;
        }

        protected override void OnReceive(object message)
        {
            Console.WriteLine($"Message received: {message}");

            if (message != null) 
            {
                emailNotification.Send(message.ToString());
            }            
        }

        protected override void PreStart()
        {
            Console.WriteLine($"{nameof(NotificationActor)} started.");
            base.PreStart();
        }

        protected override void PostStop()
        {
            Console.WriteLine($"{nameof(NotificationActor)} stopped.");
            base.PostStop();
        }
    }
}
