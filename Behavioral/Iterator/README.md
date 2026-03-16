# Iterator Design Pattern (C#)

## Intent
Provide a way to access elements of a collection sequentially without exposing its internal structure.

---

## Structure

Iterator → IIterator  
ConcreteIterator → BookIterator  
Aggregate → IAggregate  
ConcreteAggregate → BookCollection

---

## Key Takeaway
Iterator separates traversal logic from the collection.