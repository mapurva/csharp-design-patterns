# Abstract Factory Design Pattern (C#)

## Intent
Provide an interface for creating families of related objects without specifying their concrete classes.

---

## Problem
Applications often need to work with multiple related objects that must be used together.
Hardcoding object creation leads to tight coupling and poor scalability.

---

## Solution
The Abstract Factory pattern:
- Defines interfaces for related products
- Provides concrete factories for each product family
- Ensures compatible products are used together

---

## Structure
- `IButton`, `ICheckbox` – Abstract products
- `WindowsButton`, `MacButton` – Concrete products
- `IUIFactory` – Abstract factory
- `WindowsFactory`, `MacFactory` – Concrete factories
- `Program.cs` – Client code

---

## When to Use
- When products must be used in families
- When switching implementations at runtime
- When enforcing consistency across products

---

## When NOT to Use
- When only one product is needed
- When product families are unlikely to change

---

## Output
