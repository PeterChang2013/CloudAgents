using Calculator;

var engine = new CalculatorEngine();

Console.WriteLine("========================================");
Console.WriteLine("       CloudAgents Calculator v1.0");
Console.WriteLine("========================================");
Console.WriteLine();
PrintHelp();

while (true)
{
    Console.WriteLine();
    Console.Write("Enter operation (+, -, *, /, %, pow, sqrt, help, quit): ");
    var input = Console.ReadLine()?.Trim().ToLower();

    if (string.IsNullOrEmpty(input))
        continue;

    if (input is "quit" or "exit" or "q")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    if (input == "help")
    {
        PrintHelp();
        continue;
    }

    if (!CalculatorEngine.TryParseOperation(input, out var operation))
    {
        Console.WriteLine($"Unknown operation: '{input}'. Type 'help' for available operations.");
        continue;
    }

    try
    {
        if (operation == "sqrt")
        {
            var value = ReadNumber("Enter number: ");
            var result = engine.SquareRoot(value);
            Console.WriteLine($"  sqrt({value}) = {result}");
        }
        else
        {
            var a = ReadNumber("Enter first number (or 'ans' for last result): ");
            var b = ReadNumber("Enter second number (or 'ans' for last result): ");

            var result = operation switch
            {
                "+" => engine.Add(a, b),
                "-" => engine.Subtract(a, b),
                "*" => engine.Multiply(a, b),
                "/" => engine.Divide(a, b),
                "%" => engine.Modulo(a, b),
                "pow" => engine.Power(a, b),
                _ => throw new InvalidOperationException($"Unsupported operation: {operation}")
            };

            Console.WriteLine($"  {a} {operation} {b} = {result}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"  Error: {ex.Message}");
    }
}

double ReadNumber(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var input = Console.ReadLine()?.Trim().ToLower();

        if (input == "ans")
            return engine.LastResult;

        if (double.TryParse(input, out var number))
            return number;

        Console.WriteLine("  Invalid number. Please try again.");
    }
}

void PrintHelp()
{
    Console.WriteLine("Available operations:");
    Console.WriteLine("  +     Addition");
    Console.WriteLine("  -     Subtraction");
    Console.WriteLine("  *     Multiplication");
    Console.WriteLine("  /     Division");
    Console.WriteLine("  %     Modulo");
    Console.WriteLine("  pow   Power (base ^ exponent)");
    Console.WriteLine("  sqrt  Square root");
    Console.WriteLine();
    Console.WriteLine("Tips:");
    Console.WriteLine("  - Type 'ans' to use the last result as input");
    Console.WriteLine("  - Type 'help' to show this message");
    Console.WriteLine("  - Type 'quit' to exit");
}
