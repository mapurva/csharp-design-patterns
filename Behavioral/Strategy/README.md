# Strategy Design Pattern (C#)

## Intent
Define a family of algorithms, encapsulate each one, and make them interchangeable.

---

## Key Idea
Behavior can be changed at runtime without modifying the context class.

---

## Structure
- `IPaymentStrategy` – Strategy interface
- `Concrete Strategies` – Payment methods
- `ShoppingCart` – Context

---

## Key Takeaway
Strategy replaces complex conditional logic with polymorphism.