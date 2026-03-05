# Command Design Pattern (C#)

## Intent
Encapsulate a request as an object, thereby allowing parameterization of clients with queues, requests, and operations.

---

## Structure

Command → ICommand  
ConcreteCommand → TurnOnCommand  
Receiver → Light  
Invoker → RemoteControl  
Client → Program.cs

---

## Key Takeaway
Command decouples the object that invokes an operation from the one that performs it.