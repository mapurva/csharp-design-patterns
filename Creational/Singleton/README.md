# Singleton Design Pattern (C#)

## Intent
Ensure that a class has only one instance and provide a global point of access to it.

---

## Problem
In some cases, having multiple instances of a class leads to inconsistent behavior, 
such as multiple loggers writing to the same file or multiple configuration objects.

---

## Solution
The Singleton pattern:
- Makes the constructor private
- Holds a static reference to the single instance
- Provides controlled access via a public static property

This implementation is **thread-safe** using a lock.

---

## Structure
- `Singleton.cs` – Singleton class implementation
- `Program.cs` – Client code demonstrating usage

---

## When to Use
- Logging
- Configuration management
- Caching
- Shared resource access

---

## When NOT to Use
- When dependency injection can be used instead
- When global state makes testing difficult

---

## Output
