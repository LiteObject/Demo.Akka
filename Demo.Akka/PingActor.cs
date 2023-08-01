using Akka.Actor;
using Akka.Event;
using Akka.Util;

namespace Demo.Akka
{
    /* Actor:
     * - A class that can contain state and modifies that state by processing messages it receives
     * - Actor can do anything - write to a db, call api, etc. 
     * - Unit of work
     * 
     * ActorReference:
     * - A handle to an actor. Allows you to send the actor messages without knowing its implementation 
     * type or location on the network
     */
    public class PingActor : ReceiveActor
    {
        // Built-in thread-safe logging system
        private readonly ILoggingAdapter _log = Context.GetLogger();

        public PingActor()
        {
            // Message handler for messages of type Ping
            Receive<string>(p =>
            {
                _log.Info($"Received {p}");

                // Reply back
                TimeSpan replyTime = TimeSpan.FromSeconds(
                    ThreadLocalRandom.Current.Next(1, 5));

                Context.System.Scheduler.ScheduleTellOnce(
                    replyTime, // Delay
                    Sender, // Target: Reference to actor who sent us the Ping message
                    p, // Message
                    Self // Sender
                    );
            });
        }
    }
}
