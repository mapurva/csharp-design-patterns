# Template Method Design Pattern (C#)

## Intent
Define the skeleton of an algorithm in a method, deferring some steps to subclasses.

---

## Key Idea
The overall workflow remains fixed while specific steps are customizable.

---

## Structure

AbstractClass → DataProcessor  
ConcreteClass → CSVProcessor, JSONProcessor  
TemplateMethod → Process()

---

## Key Takeaway
Template Method promotes code reuse by defining common algorithm structure.