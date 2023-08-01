using Akka.Actor;

namespace Demo.Akka
{
    public class NotificationActor : UntypedActor
    {
        private readonly IEmailNotification emailNotification;

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
