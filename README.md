# CloudAgents Calculator

A simple, interactive console calculator application built with C# and .NET.

## Description

CloudAgents Calculator is a command-line calculator that supports basic arithmetic operations along with advanced mathematical functions. The application features an interactive loop where users can perform calculations continuously and even reference previous results using the `ans` keyword.

## Features

- **Addition (+)** - Add two numbers
- **Subtraction (-)** - Subtract one number from another
- **Multiplication (*)** - Multiply two numbers
- **Division (/)** - Divide one number by another (with zero-division protection)
- **Power (pow)** - Calculate base raised to an exponent
- **Square Root (sqrt)** - Calculate the square root of a number (with negative number validation)
- **Modulo (%)** - Calculate the remainder of division (with zero-division protection)

### Additional Features

- **Result Memory** - Use `ans` to reference the last calculated result
- **Interactive Help** - Type `help` to display available operations
- **Graceful Exit** - Type `quit`, `exit`, or `q` to exit the application

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download) or later

## How to Build

Navigate to the repository root and run:

```bash
dotnet build
```

This will compile the solution and produce the output in `src/Calculator/bin/Debug/net9.0/`.

## How to Run

After building, run the application with:

```bash
dotnet run --project src/Calculator
```

Or navigate to the Calculator project directory and run:

```bash
cd src/Calculator
dotnet run
```

## Usage Example

```
========================================
       CloudAgents Calculator v1.0
========================================

Available operations:
  +     Addition
  -     Subtraction
  *     Multiplication
  /     Division
  %     Modulo
  pow   Power (base ^ exponent)
  sqrt  Square root

Enter operation (+, -, *, /, %, pow, sqrt, help, quit): +
Enter first number (or 'ans' for last result): 10
Enter second number (or 'ans' for last result): 5
  10 + 5 = 15

Enter operation (+, -, *, /, %, pow, sqrt, help, quit): sqrt
Enter number: 16
  sqrt(16) = 4

Enter operation (+, -, *, /, %, pow, sqrt, help, quit): quit
Goodbye!
```

## Project Structure

```
├── CloudAgents.sln
├── README.md
└── src/
    └── Calculator/
        ├── Calculator.csproj
        ├── CalculatorEngine.cs    # Core calculation logic
        └── Program.cs             # Interactive console interface
```

## License

This project is provided as-is for educational and demonstration purposes.
