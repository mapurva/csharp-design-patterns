# Interpreter Design Pattern (C#)

## Intent
Define a representation for a language’s grammar and provide an interpreter to evaluate sentences.

---

## Structure

Expression → IExpression  
Terminal → Number  
Non-Terminal → AddExpression, SubtractExpression  

---

## Key Takeaway
Interpreter evaluates expressions by building an object tree.