# C# Step-by-Step Learning Plan

A concise, practical roadmap to learn C# from the ground up. Follow each lesson, run the short examples, and try the exercises.

**Plan**
- **1 Create learning plan:** High-level roadmap (done).
- **2 Setup environment:** Install .NET SDK and editor.
- **3 Hello World project:** Create, run, inspect project.
- **4 C# basics:** Types, variables, operators.
- **5 Control flow:** Conditionals, loops, switch.
- **6 OOP:** Classes, structs, properties, inheritance, interfaces.
- **7 Collections & LINQ:** Lists, dictionaries, queries.
- **8 Async & concurrency:** `async`/`await`, Tasks.
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

`dotnet new console` scaffolds a small C# app; `dotnet run` builds and executes it.

3) Example `Program.cs` (simple form):

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

Try editing the string, then re-run `dotnet run` to see the change.

---

Next: Lesson 2 — C# types, variables, and operators. Would you like me to add that lesson here now?
