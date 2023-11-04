
Console.WriteLine("Welcome to Tail Recursive Fibonacci Calculation!");
Console.Write("Enter 1 for Factorial, 2 for Fibonacci calculation: ");
var choice = Console.ReadLine();
if (int.TryParse(choice, out int choiceValue))
{
    if (choiceValue == 1)
    {
        Console.Write("Enter Factorial Input: ");
        var facTarget = Console.ReadLine();
        if (int.TryParse(facTarget, out int facInput))
        {
            var fac = new Factorial(facInput);
            Console.WriteLine(fac);
        }
    }

    else
    {
        Console.Write("Enter Fibonacci Input: ");
        var fibTarget = Console.ReadLine();
        if (int.TryParse(fibTarget, out int fibInput))
        {
            var fib = new Fibonacci(fibInput);
            Console.WriteLine(fib);
        }
    }
}

Console.ReadLine();

