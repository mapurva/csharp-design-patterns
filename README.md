# Singleton Pattern (C#)

## Intent
Ensure that a class has only one instance and provide a global access point to it.

## Problem
Multiple instances of a class like Logger or Configuration can cause inconsistent behavior.

## Solution
- Make constructor private
- Create a static instance
- Provide a public static method to access it

## When to Use
- Logging
- Configuration settings
- Database connection (conceptually)

## Output
Singleton instance created  
Hello from Singleton  
Both are same instance
