# Factory Method Design Pattern (C#)

## Intent
Define an interface for creating an object, but let subclasses decide which class to instantiate.

---

## Problem
Direct object creation using `new` tightly couples the client code to concrete classes.
This makes the system hard to extend and maintain.

---

## Solution
The Factory Method pattern:
- Defines a factory method in a base class
- Allows subclasses to decide which product to create
- Separates object creation from usage

---

## Structure
- `IProduct` – Product interface
- `ConcreteProductA/B` – Concrete implementations
- `Creator` – Declares factory method
- `ConcreteCreatorA/B` – Implements factory method
- `Program.cs` – Client code

---

## When to Use
- When object creation logic is complex
- When adding new product types frequently
- When following Open–Closed Principle

---

## When NOT to Use
- When object creation is simple
- When there is no variation in products

---

## Output
