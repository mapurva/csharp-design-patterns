# Visitor Design Pattern (C#)

## Intent
Represent an operation to be performed on elements of an object structure without modifying the classes.

---

## Structure

Visitor → IVisitor  
ConcreteVisitor → AreaVisitor, DrawVisitor  
Element → IShape  
ConcreteElement → Circle, Rectangle  

---

## Key Takeaway
Visitor allows adding new behavior without modifying existing classes.