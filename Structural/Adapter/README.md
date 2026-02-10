# Adapter Design Pattern (C#)

## Intent
Convert the interface of a class into another interface clients expect.

---

## Problem
Existing code expects `IPaymentProcessor`, but the bank library provides `LegacyBankAPI`.

---

## Solution
Create an Adapter that translates requests from the new interface to the legacy interface.

---

## Structure
- `IPaymentProcessor` – Target interface
- `LegacyBankAPI` – Adaptee
- `BankAdapter` – Adapter
- `Program.cs` – Client

---

## Key Takeaway
Adapter allows integration with old or third-party code without modifying it.
