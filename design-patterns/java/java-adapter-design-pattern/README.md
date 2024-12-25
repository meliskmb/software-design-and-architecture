# Adapter Pattern Example in Java

This project demonstrates the use of the **Adapter Design Pattern** in Java. The Adapter Pattern is a structural design pattern that allows objects with incompatible interfaces to work together.

## Key Components
- **DB Interface**: Defines the standard operations for database interaction.
- **Oracle Class**: A simple implementation of the `DB` interface.
- **Mssql Class**: Represents a legacy database system with a different API.
- **MssqlAdapter**: Adapts the `Mssql` class to work with the `DB` interface.

## How It Works
1. The `Service` class depends on the `DB` interface for database operations.
2. The `Mssql` class has its own methods for managing users but doesn't conform to the `DB` interface.
3. The `MssqlAdapter` class implements the `DB` interface and internally uses an instance of the `Mssql` class. This allows the `Service` class to interact with `Mssql` as if it were a `DB` implementation.

## Why Use the Adapter Pattern?
The Adapter Pattern is useful when:
- You want to integrate a class with an existing codebase that expects a different interface.
- You need to reuse a class that doesn't conform to the desired interface without modifying its source code.