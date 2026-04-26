## Exercise 1: Code Review

# Issues identified:

1. Poor indentation in some areas
Code was not correctly indented.

2. Typos in multiple places and misleading comments:
Typos present in code as well as descriptive comments and summary. Some comments were also misleading which should be more descriptive and appropriate. Class, method and variable names were not descriptive or misleading.

3. Code correctness
Logical bugs (eg. Random value, Wrong age calculation)
Improper exception handling
Unused expressions (e.g., Substring result not returned, unused constructor)

4. Design issues
Hardcoded values were used instead of using constants

## Exercise 2: Gilded rose refactoring kata

# Issues identified and fixed:

1. Violation of SRP
The class was implementing all the logic for checking the type, updating the quality and sellin for each type.
FIX: Created seperate handlers for each type

2. Heavy nested conditions
Code readability compromised because of heavy use of nested conditions.
FIX: Seperate handlers reduced the nested conditions

3. Extension of Conjured items difficult with the code
Because of all code being in same place, adding logic for conjured items could have impacted the existing logic/flow
FIX: Added seperate handler for Conjured items without modifying existing logic. Any new item can now be added easily.

4. Complex loop with multiple responsibilities:
FIX: Seperation of concerns helped to have clean single loop in UpdateQuality method with delegated responsibility

5. Hardcoded items in Program.cs
FIX: Seperate class created for hardcoded items making the code clean.

# Use of AI Assistance

1. To create the factory and its logic.
2. To generate the class to return the list of items.
3. To identify the best approach to handle Sulfuras item where no action was required.