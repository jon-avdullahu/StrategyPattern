# Strategy Pattern Navigation System

## Overview

This project demonstrates the Strategy Pattern using a navigation system. The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm's behavior at runtime. It allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. This pattern is important because it promotes flexibility and reusability by allowing the algorithm to vary independently from the clients that use it.

## Project Structure

- **Interface**: `IRouteStrategy` defines the contract for all strategies.
- **Strategies**: 
  - `WalkingStrategy`
  - `DrivingStrategy`
  - `CyclingStrategy`
- **Context**: `NavigationContext` uses a strategy to perform route calculations.
- **Program**: Demonstrates how to use the context and switch strategies.

## Running the Code

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd StrategyPattern
   ```

2. **Build the Solution**:
   Open the solution in Visual Studio and build it.

3. **Run the Application**:
   Execute the `StrategyPattern` project to see the strategy pattern in action.

4. **Run Unit Tests**:
   Use the Test Explorer in Visual Studio to run all tests in the `StrategyPattern.Test` project.

## Requirements

- Visual Studio 2022
- .NET 6.0 or later
- xUnit for testing
