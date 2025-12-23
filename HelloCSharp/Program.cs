// C# basics: types, variables, operators
using System;

class Program
{
	static void Main()
	{
		// Primitive types
		int a = 5;
		long big = 1234567890123L;
		double pi = 3.14159;
		bool flag = true;
		char letter = 'A';
		string name = "Jairam";
		var inferred = 42; // type inferred as int
		const double Tax = 0.07;

		Console.WriteLine($"int a = {a}, long big = {big}, double pi = {pi}");
		Console.WriteLine($"bool flag = {flag}, char letter = {letter}, string name = {name}");
		Console.WriteLine($"var inferred = {inferred}, const Tax = {Tax}");

		// Nullable
		int? maybe = null;
		Console.WriteLine($"nullable int maybe has value: {maybe.HasValue}");

		// Arithmetic operators
		int sum = a + inferred;
		int prod = a * 2;
		double div = inferred / 3.0;
		bool cmp = a > 3;
		Console.WriteLine($"sum={sum}, prod={prod}, div={div}, a>3={cmp}");

		// Logical operators
		bool logic = (a > 0) && flag;
		Console.WriteLine($"logic (a>0 && flag) = {logic}");

		// Ternary
		string parity = (a % 2 == 0) ? "even" : "odd";
		Console.WriteLine($"a is {parity}");

		// Strings and interpolation
		string greeting = $"Hello, {name.ToUpper()}!";
		Console.WriteLine(greeting);

		// Parsing and TryParse
		string input = "123";
		if (int.TryParse(input, out int parsed))
			Console.WriteLine($"Parsed int: {parsed}");

		// Casting
		int casted = (int)pi; // truncates
		Console.WriteLine($"(int)pi = {casted}");

		// Tuples
		var point = (x: 3, y: 4);
		Console.WriteLine($"point = ({point.x}, {point.y})");

		// Small exercises prompt
		Console.WriteLine("--- Exercises ---");
		Console.WriteLine("1) Change variable values and re-run.");
		Console.WriteLine("2) Try to parse a non-number and handle it.");
	}
}
