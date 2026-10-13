# OOP Lexicon Exercises

A C# console project that applies object-oriented programming concepts. It includes exercises for reading person details, sorting people, increasing salaries, and validating data.

## Requirements and running the project

The .NET 10 SDK is required. Run the following command from the solution directory:

```sh
dotnet run --project OOPLexiconExercise/OOPLexiconExercise.csproj
```

You can also run the project in Visual Studio.

## Menu

- `1`: Runs the person sorting exercise.
- `2`: Runs the salary increase exercise.
- Any other input: Exits the program.

The menu appears again after an exercise finishes. The program starts with top-level statements in Program.cs; no explicit Main method is used.

## 1. Sorting people

Enter the first name, last name, and age of five people, one person per line, with fields separated by spaces:

```text
Anna Persson 65
Anna Andersson 34
Johanna Eriksson 57
Johanna Svensson 27
Erika Samuelsson 35
```

The current implementation sorts people by age first, then by first name when their ages are equal. The original assignment requires sorting by first name first, then by age.

Each person is printed in this format:

```text
Johanna Svensson is 27 years old.
```

## 2. Increasing salaries

Enter the first name, last name, age, and salary of five people:

```text
Anna Persson 25 1000
Erik Andersson 29 2000
Johanna Svensson 30 1000
Lars Eriksson 45 2000
Eva Karlsson 65 3000
```

Then enter the salary increase percentage to apply to everyone. For example, `10` means a 10% increase.

- People younger than 30 receive half of the specified increase percentage.
- People aged 30 or older receive the full increase percentage.

For example, a 25-year-old earning 1000 receives a salary of 1050 after a 10% increase. A 30-year-old earning the same amount receives 1100.

Salaries are displayed with two decimal places. The decimal separator depends on the system's regional settings; use the same separator when entering decimal salaries and percentages.

## Data validation

Validation is performed in the shared Person class and applies to both exercises:

| Field | Rule | Error message |
| --- | --- | --- |
| First name | Must contain at least 3 characters and must not be blank | First name cannot contain fewer than 3 symbols! |
| Last name | Must contain at least 3 characters and must not be blank | Last name cannot contain fewer than 3 symbols! |
| Age | Must be greater than zero | Age cannot be zero or a negative integer! |
| Salary | Must be at least 460 | Salary cannot be less than 460 dollar! |

An invalid value throws an ArgumentException. The exercise displays the error message and asks for the same person's details again. The invalid entry does not count toward the five valid people.

Fields must be entered in the specified order, and numeric fields must use a valid number format. Error handling for missing fields or text entered instead of numbers has not yet been added.

## Project structure

- `Program.cs`: Contains the selection menu and while loop.
- `Person.cs`: Contains private fields, readable properties, constructors, validation, the IncreaseSalary method, and the ToString output.
- `PersonExercise.cs`: Reads and sorts five people without requesting a salary.
- `PersonExercise2.cs`: Reads five people with their salaries and applies a salary increase.

The Person class uses constructor overloading. The three-parameter constructor calls the four-parameter constructor with a default salary of 460. This keeps validation in one place. The default salary was chosen to preserve the first exercise.

## Concepts used

Encapsulation, constructor overloading, constructor chaining, methods, overriding ToString, LINQ sorting, List<T>, loops, and exception handling with try/catch.
