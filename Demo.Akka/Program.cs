using Akka.Actor;
using Akka.DI.Core;
using Akka.DI.Extensions.DependencyInjection;
using Demo.Akka;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IEmailNotification, EmailNotification>();
services.AddSingleton<NotificationActor>();
var provider = services.BuildServiceProvider();

using var actorSystem = ActorSystem.Create("test-actor-system");
actorSystem.UseServiceProvider(provider);

var actor = actorSystem.ActorOf(actorSystem.DI().Props<NotificationActor>());
actor.Tell("Hello World!!!");

// Need to wait, othersie actor system will stop before completion.
Console.Read();

actorSystem.Stop(actor);

Console.WriteLine("\n\nPress any key to exit.");

