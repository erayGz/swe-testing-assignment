# Testing Strategy

The goal of testing in this project is to verify that the calculator behaves correctly for different inputs and scenarios.

Two types of testing were implemented:

- Unit Testing
- Integration Testing

---

# Unit Testing

Unit tests focus on testing individual methods inside the **Calculator** class.

Each arithmetic operation was tested independently:

- Addition
- Subtraction
- Multiplication
- Division

Edge cases were also tested such as:

- Division by zero
- Negative numbers
- Decimal values
- Large numbers

Unit testing ensures that each function works correctly in isolation.

---

# Integration Testing

Integration tests verify that different parts of the system work together correctly.

In this project the interaction between:

- **QuickCalc.App**
- **QuickCalc.Core**

was tested.

The application layer processes input and forwards calculations to the core logic.

Example integration scenarios:

- `"5 + 3"` should return `"8"`
- `"5 / 0"` should return `"ERR"`

This confirms that the application layer and calculation logic integrate correctly.

---

# Testing Concepts Applied

The testing approach follows several software testing concepts:

### Testing Pyramid
Most tests are **unit tests**, while a smaller number are **integration tests**.

### Black-Box Testing
Inputs and outputs are tested without relying on internal implementation details.

### White-Box Testing
Tests were written with knowledge of internal logic to ensure proper code coverage.

### Regression Testing
Tests can be re-run after changes to ensure that existing functionality is not broken.

---

# Test Summary

| Test Type | Count | Result |
|----------|------|-------|
| Unit Tests | 8 | Passed |
| Integration Tests | 2 | Passed |
| Total Tests | 10 | Passed |

All tests passed successfully.
