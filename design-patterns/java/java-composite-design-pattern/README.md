# Java Adapter Design Pattern

This folder contains an example implementation of the **Adapter Design Pattern** in Java.

## Overview
The Adapter Pattern is used to bridge the gap between two incompatible interfaces. This example demonstrates how to adapt a legacy `Mssql` class to a standard `DB` interface using an `MssqlAdapter`.

## Key Components
- **DB Interface**: Defines the standard operations for database interaction.
- **Oracle Class**: A simple implementation of the `DB` interface.
- **Mssql Class**: Represents a legacy database system with a different API.
- **MssqlAdapter**: Adapts the `Mssql` class to work with the `DB` interface.
  
## How It Works
1. The `Service` class depends on the `DB` interface for database operations.
2. The `Mssql` class has its own methods for managing users but doesn't conform to the `DB` interface.
3. The `MssqlAdapter` class implements the `DB` interface and internally uses an instance of the `Mssql` class. This allows the `Service` class to interact with `Mssql` as if it were a `DB` implementation.
 
## Why Use Adapter Pattern?
The Adapter Pattern is useful when:
- You want to integrate a class with an existing codebase that expects a different interface.
- You need to reuse a class that doesn't conform to the desired interface without modifying its source code.
