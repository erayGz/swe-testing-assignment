# swe-testing-assignment
# QuickCalc

QuickCalc is a simple calculator project developed in C# using .NET.  
The purpose of this project is to demonstrate basic software testing practices, including unit testing and integration testing.

The calculator supports basic arithmetic operations:

- Addition
- Subtraction
- Multiplication
- Division

The project is structured into three parts:

- **QuickCalc.Core** – contains the calculator logic
- **QuickCalc.App** – simple application layer that processes user input
- **QuickCalc.Tests** – contains unit and integration tests

---

# Project Structure
## Project Structure

```text
QuickCalc/
├── QuickCalc.Core/      (calculator logic)
├── QuickCalc.App/       (application layer + input evaluation)
├── QuickCalc.Tests/     (unit tests + integration tests)
└── QuickCalc.sln
```
---

# How to Build the Project

To build the project run:

dotnet build QuickCalc.sln


---

# How to Run the Application

dotnet run --project QuickCalc.App

---

# Running Tests

To execute all tests run:

dotnet test QuickCalc.sln


---

# Testing Framework Comparison

This project uses **xUnit** as the testing framework.

xUnit is one of the most widely used testing frameworks in modern .NET development.  
It provides a clean syntax and encourages better test isolation.

Compared to other frameworks:

- **NUnit** also provides strong testing features but requires more attributes and setup.
- **MSTest** is integrated into Visual Studio but is considered less flexible.

xUnit was chosen because it is lightweight, easy to use, and commonly used in modern .NET projects.
