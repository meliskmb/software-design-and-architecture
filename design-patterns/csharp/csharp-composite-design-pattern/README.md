# Composite Design Pattern Example in C#

This project demonstrates the use of the **Composite Design Pattern** in C#. The Composite Pattern is a structural design pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

## Key Components

1. **IEmployee Interface**  
   - Defines the standard operations for employees.
   - Implemented by `Designer`, `Developer`, `Manager`, and `HumanResources`.

2. **Designer Class (Leaf)**  
   - Represents a designer employee.
   - Implements the `IEmployee` interface.

3. **Developer Class (Leaf)**  
   - Represents a developer employee.
   - Implements the `IEmployee` interface.

4. **Manager Class (Leaf)**  
   - Represents a manager employee.
   - Implements the `IEmployee` interface.

5. **HumanResources Class (Composite)**  
   - Represents a group of employees.
   - Can contain multiple `IEmployee` objects (either Leaf or Composite).
   - Implements the `IEmployee` interface.

## How It Works

- The `IEmployee` interface defines a method `ShowInfo()` that is implemented by all components (both leaf and composite).
- The `Designer`, `Developer`, and `Manager` classes are leaf nodes, representing individual employees.
- The `HumanResources` class is a composite node that can hold a group of employees (both leaf and composite) and provides operations to add or remove employees.
- In the `Program` class:
  - Multiple composite and leaf nodes are created.
  - A tree structure is formed with `HumanResources` nodes.
  - The `ShowInfo()` method is called on the root node, which recursively calls the method for all its children.

## Why Use the Composite Pattern?

The Composite Pattern is useful when:
- You need to represent a part-whole hierarchy of objects.
- You want to treat individual objects and compositions of objects uniformly.
- You want to simplify the client code by allowing it to work with a single interface (`IEmployee`) regardless of whether it’s dealing with a leaf or a composite.
