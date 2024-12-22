# Unassigned Property Access in C#

This repository demonstrates a common yet easily overlooked error in C#: accessing a property before assigning it a value.  Uninitialized properties will have default values (0 for integers, null for objects, etc.), which may not be what your code expects.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a corrected version that ensures the property is initialized before use.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs` (you'll likely see an unexpected output, potentially 0).
3. Compile and run `bugSolution.cs` (you'll get the expected output).

## Lesson Learned

Always initialize properties explicitly, especially when their initial values are crucial for correct program behavior. This practice enhances code readability and prevents subtle, hard-to-debug errors.