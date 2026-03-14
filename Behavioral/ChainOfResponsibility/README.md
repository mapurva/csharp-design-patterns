# Chain of Responsibility Design Pattern (C#)

## Intent
Allow multiple objects to handle a request by passing it along a chain until one handles it.

---

## Structure

Handler → SupportHandler  
ConcreteHandlers → BasicSupport, Supervisor, Manager  
Client → Program.cs

---

## Key Takeaway
Chain of Responsibility decouples the sender from the receiver.