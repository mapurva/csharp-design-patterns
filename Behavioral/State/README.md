# State Design Pattern (C#)

## Intent
Allow an object to alter its behavior when its internal state changes.

---

## Structure
State → IState  
ConcreteState → NoCoinState, HasCoinState  
Context → VendingMachine  
Client → Program.cs

---

## Key Takeaway
State removes large conditional logic by delegating behavior to state objects.