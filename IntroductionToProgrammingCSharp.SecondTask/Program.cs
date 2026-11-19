namespace IntroductionToProgrammingCSharp.SecondTask;

internal class Program
{
    private static void Main()
    {
        var x = ReadNumber("x");
        var y = ReadNumber("y");
        var z = ReadNumber("z");
        var a = ReadNumber("a");
        var b = ReadNumber("b");

        var firstDenominator = 3 * (x + 6);
        var secondDenominator = z + 7 * b;

        if (firstDenominator == 0)
        {
            throw new DivideByZeroException("First denominator cannot be zero.");
        }

        if (secondDenominator == 0)
        {
            throw new DivideByZeroException("Second denominator cannot be zero.");
        }

        var firstFraction = (y + 6 * a - 2) / firstDenominator;
        var secondFraction = z / secondDenominator;

        var result = Math.Pow(firstFraction, 6) - secondFraction;

        Console.WriteLine($"Result: {result}");
    }

    private static double ReadNumber(string name)
    {
        while (true)
        {
            Console.Write($"Enter {name}: ");

            if (double.TryParse(Console.ReadLine(), out var value) && double.IsFinite(value))
            {
                return value;
            }

            Console.WriteLine("Invalid number. Try again.");
        }
    }
}