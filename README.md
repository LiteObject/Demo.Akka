# Actor Model with Akka.NET

Akka.NET is an open-source framework for building highly concurrent, distributed, and 
fault-tolerant systems based on the actor model.

## What is Actor Model?

> The actor model in computer science is a mathematical model of concurrent computation 
that treats actor as the universal primitive of concurrent computation. In response to a 
message it receives, an actor can: make local decisions, create more actors, send more 
messages, and determine how to respond to the next message received. Actors may modify 
their own private state, but can only affect each other indirectly through messaging 
(removing the need for lock-based synchronization).

## How is Actor model different from virtual actor model?
Actors are typically implemented as threads or processes, and are responsible for managing 
their own state and message queues. In the Virtual Actor model, actors are implemented as 
stateless objects that are managed by a runtime system, which provides features such as 
automatic load balancing, failover, and distributed garbage collection. Another difference 
is that the Virtual Actor model provides a higher level of abstraction than the Actor model, 
which can make it easier to reason about and manage complex distributed systems.

## Akka.NET can be used to solve the following types of problems:
* Concurrency 
* Stream Processing 
* Event-Driven Programming 
* Event Sourcing and CQRS
* Location Transparency 
* Highly Available, Fault-Tolerant Distributed Systems
* Low Latency, High Throughput

## Three major advantages of Akka
* Multithreaded behavior without the use of low-level concurrency constructs
* Transparent remote communication between systems and their components. No need to write or maintain a difficult network code.
* A clustered high availability architecture that is elastic, increases or decreases, on demand.

## Akka Libraries
* Akka (base types)
* Akka.Remote (networking)
* Akka.Persistence (durable actors)
* Akka.Cluster (HA networking)
* Akka.Stream 

---
 ## Links:
 - [github.com/akkadotnet](https://github.com/akkadotnet)
 - [Microsoft Orleans](https://learn.microsoft.com/en-us/dotnet/orleans/overview)




