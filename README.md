# C# Step-by-Step Learning Plan

A concise, practical roadmap to learn C# from the ground up. Work through each lesson, run the short examples, and try the exercises.

**Plan**
- **1 Create learning plan:** High-level roadmap (completed).
- **2 Setup environment:** Install .NET SDK and editor (completed).
- **3 Hello World project:** Create, run, inspect project (completed).
- **4 C# basics:** Types, variables, operators (completed).
- **5 Control flow:** Conditionals, loops, switch (in-progress).
- **6 OOP:** Classes, structs, properties, inheritance, interfaces.
- **7 Collections & LINQ:** Lists, dictionaries, queries.
- **8 Async & concurrency:** `async`/`await`, `Task`.
- **9 Error handling & testing:** Exceptions, debugging, xUnit.
- **10 Build a sample app:** Console or simple web API.
- **11 Next steps & resources:** Advanced topics and practice.

---

## Lesson 1 — Environment & Hello World

1) Check .NET installation:

```bash
dotnet --info
```

2) Create and run a console app:

```bash
dotnet new console -o HelloCSharp
cd HelloCSharp
dotnet run
```

3) Example `Program.cs` (basic):

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, C#!");
    }
}
```

---

## Lesson 2 — Types, Variables, Operators

Core concepts:
- Value types: `int`, `long`, `double`, `bool`, `char`, `struct`.
- Reference types: `string`, arrays, `class`, `object`.
- `var` for type inference and `const` for constants.
- Nullable value types with `T?`.

Examples (try in `Program.cs`):

```csharp
int a = 5;
double pi = 3.14;
bool ok = true;
string name = "Alice";
var inferred = 42; // inferred as int
int? maybe = null; // nullable

int sum = a + inferred;
double div = inferred / 3.0;
bool cmp = a > 3;
string greeting = $"Hello, {name}!";
```

Operators:
- Arithmetic: `+ - * / %`.
- Comparison: `== != > < >= <=`.
- Logical: `&& || !`.
- Ternary: `condition ? a : b`.

Exercises:
- Change variable values and observe results.
- Parse a string with `int.TryParse` and handle failures.

---

## Lesson 3 — Control Flow & Loops

Conditionals:

```csharp
if (x > 0) { }
else if (x == 0) { }
else { }

switch (value)
{
    case 1:
        break;
    default:
        break;
}
```

Loops:
- `for`, `while`, `do { } while`, and `foreach` for collections.

Example:

```csharp
for (int i = 0; i < 5; i++)
    Console.WriteLine(i);

int i = 0;
while (i < 5) { Console.WriteLine(i); i++; }

foreach (var item in list) Console.WriteLine(item);
```

Exercises:
- Sum numbers 1..100 with a loop.
- Write a simple menu using `switch`.

---

## Lesson 4 — Object-Oriented Programming

Key topics:
- `class` vs `struct`.
- Fields, properties, methods, constructors.
- Inheritance (`:`), `virtual`/`override`.
- Interfaces (`interface`) and polymorphism.
- Access modifiers: `public`, `private`, `protected`, `internal`.

Example:

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age) { Name = name; Age = age; }
    public virtual string Greet() => $"Hi, I'm {Name}.";
}

public class Employee : Person
{
    public int Id { get; }
    public Employee(string name, int age, int id): base(name, age) { Id = id; }
    public override string Greet() => base.Greet() + $" My id is {Id}.";
}
```

Exercises:
- Create a small class hierarchy with an interface.

---

## Lesson 5 — Collections & LINQ

Collections:
- `List<T>`, `Dictionary<TKey,TValue>`, arrays, `HashSet<T>`.

LINQ (Language Integrated Query) for querying collections:

```csharp
var numbers = new List<int> {1,2,3,4,5};
var even = numbers.Where(n => n % 2 == 0).ToList();
var sum = numbers.Sum();
```

Exercises:
- Use LINQ to filter, order, and group data.

---

## Lesson 6 — Asynchronous Programming

Use `async`/`await` and `Task` for non-blocking operations.

```csharp
public async Task<string> GetAsync()
{
    await Task.Delay(100);
    return "done";
}
```

Exercises:
- Call an async method from `Main` (use `await` in an `async Task Main`).

---

## Lesson 7 — Error Handling & Testing

Exceptions:

```csharp
try {
    // risky code
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
finally {
    // cleanup
}
```

Testing:
- Use `dotnet new xunit` and `dotnet test` for unit tests.

Exercises:
- Write tests for small methods with edge cases.

---

## Lesson 8 — Building a Small App

Pick one:
- Console app (calculator, todo list).
- Minimal Web API using `dotnet new webapi`.

Checklist:
- Create project, add models, add simple I/O or endpoints, test manually.

---

## Lesson 9 — Tooling, Debugging, and Best Practices

- Use an editor (VS Code, Visual Studio) with C# extension.
- Use the debugger, breakpoints, and watch expressions.
- Formatting and analyzers: `dotnet format`, Roslyn analyzers.

---

## Lesson 10 — Next Steps & Resources

Suggested next topics:
- Design patterns, dependency injection, EF Core, ASP.NET Core, Microservices.

Resources:
- Official docs: https://learn.microsoft.com/dotnet/csharp
- C# interactive tutorials and sample repos on Microsoft Learn.

---

## Quick Commands

```bash
# Create a console app
dotnet new console -o HelloCSharp
cd HelloCSharp
dotnet run

# Create xUnit tests
dotnet new xunit -o Tests
dotnet test
```

---

If you want, I can expand any lesson with step-by-step examples, add runnable sample projects under this repo, or create unit tests and exercises. Which lesson shall I expand next?
