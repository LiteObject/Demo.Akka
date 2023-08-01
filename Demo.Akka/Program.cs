using Akka.Actor;
using Akka.DI.Core;
using Akka.DI.Extensions.DependencyInjection;
using Demo.Akka;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddSingleton<IEmailNotification, EmailNotification>();
services.AddSingleton<NotificationActor>();
ServiceProvider provider = services.BuildServiceProvider();

// ActorSystem: A collection of actors that exist inside a single process and communicate via in-memory
// Cluster: A collection of networked ActorSystems whose actors communicate via TCP

// Create ActorSystem (allows actors to talk in-memory)
using ActorSystem actorSystem = ActorSystem.Create("test-actor-system");
actorSystem.UseServiceProvider(provider);

// Props: Formula used to start an actor
Props actorProps = Props.Create(() => new PingActor());

// Start actor (of type PingActor) and get actor reference
IActorRef actor = actorSystem.ActorOf(props: actorSystem.DI().Props<NotificationActor>(), name: "");
actor.Tell("Hello World!!!");

// Need to wait, otherwise actor system will stop before completion.
Console.Read();

actorSystem.Stop(actor);

Console.WriteLine("\n\nPress any key to exit.");

