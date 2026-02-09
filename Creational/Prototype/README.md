# Prototype Design Pattern (C#)

## Intent
Create new objects by copying an existing object (prototype) instead of creating new instances from scratch.

---

## Problem
Object creation may be expensive or complex, especially when initialization involves heavy configuration.

---

## Solution
The Prototype pattern:
- Clones an existing object
- Avoids expensive construction
- Improves performance

---

## Structure
- `Prototype` – Abstract base class
- `Student` – Concrete prototype
- `Program.cs` – Client

---

## When to Use
- Expensive object creation
- Object templates
- Caching preconfigured objects

---

## When NOT to Use
- Simple object creation
- When deep copy is very complex

---

## Output
Shows cloning of object and independence of original and cloned instances.

---

## Key Takeaway
Prototype creates objects by duplication rather than instantiation.
