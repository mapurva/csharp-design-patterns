# Builder Design Pattern (C#)

## Intent
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

---

## Problem
Large constructors with many parameters are hard to read, error-prone, and difficult to extend.

---

## Solution
The Builder pattern:
- Creates objects step-by-step
- Uses method chaining
- Improves readability and flexibility

---

## Structure
- `Student` – Product
- `StudentBuilder` – Builder
- `Program.cs` – Client

---

## When to Use
- Objects with many optional parameters
- Configuration objects
- Complex object creation

---

## When NOT to Use
- Simple objects with few parameters

---

## Output
