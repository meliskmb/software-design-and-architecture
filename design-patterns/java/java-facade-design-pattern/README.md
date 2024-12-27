# Facade Design Pattern Example in Java

This project demonstrates the use of the **Facade Design Pattern** in Java. The Facade Pattern is a structural design pattern that provides a simplified interface to a set of complex subsystems, making them easier to use.

## Key Components
- **AirConditioning Class**: Manages the air conditioning system, including turning it on/off and adjusting the temperature.
- **Door Class**: Handles locking and unlocking of the door.
- **Light Class**: Controls the lighting system, allowing all lights to be turned on or off.
- **TV Class**: Manages turning the television on or off.
- **Facade Class**: Provides a unified interface to control all subsystems through simplified methods.

## How It Works
1. The `Facade` class acts as a central interface that provides high-level methods for controlling all subsystems.
2. Subsystems (e.g., `AirConditioning`, `Door`, `Light`, `TV`) expose their individual functionalities through their own methods.
3. The `Facade` class internally calls these methods to perform complex operations, such as activating `sleepMode`:
   - Turns off the air conditioning.
   - Locks the door.
   - Turns off all lights.
   - Turns off the TV.

## Why Use the Facade Pattern?
The Facade Pattern is useful when:
- You need to simplify the interface to a complex system by providing a single entry point.
- You want to improve usability by reducing the number of interactions with individual subsystems.
- You aim to decouple client code from subsystems, making the code easier to maintain and extend.

