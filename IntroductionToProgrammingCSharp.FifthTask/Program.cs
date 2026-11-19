namespace IntroductionToProgrammingCSharp.FifthTask;

internal class Program
{
    private static void Main()
    {
        PrintPositiveRandomNumbers();
        PrintSumOfNegativeOrOver200Numbers();
        PrintDifferenceOfRandomAverages();
    }

    private static void PrintPositiveRandomNumbers()
    {
        Console.WriteLine("32 random numbers [0; 50]:");

        for (var i = 0; i < 32; i++)
        {
            var number = Random.Shared.Next(0, 51);

            if (number > 0)
            {
                Console.Write($"{number} ");
            }
        }

        Console.WriteLine();
    }

    private static void PrintSumOfNegativeOrOver200Numbers()
    {
        Console.WriteLine("\nSum of negative or greater than 200 numbers:");

        var sum = 0.0;

        for (var i = 1; i <= 7; i++)
        {
            var number = ReadNumber($"Number {i}");

            if (number is < 0 or > 200)
            {
                sum += number;
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }

    private static void PrintDifferenceOfRandomAverages()
    {
        Console.WriteLine("\nDifference between averages:");

        var a = ReadPositiveInteger("a");
        var b = ReadPositiveInteger("b");
        var c = ReadPositiveInteger("c");

        var firstAverage = Sred(Math.Abs(a - b));
        var secondAverage = Sred(c + a);

        if (!firstAverage.HasValue || !secondAverage.HasValue)
        {
            Console.WriteLine("Cannot calculate average: no qualifying numbers.");

            return;
        }

        var result = firstAverage.Value - secondAverage.Value;

        Console.WriteLine($"Result: {result}");
    }

    private static double? Sred(int k)
    {
        var sum = 0;
        var count = 0;

        for (var i = 0; i < k; i++)
        {
            var number = Random.Shared.Next(0, 201);

            if (number is < 10 or > 100)
            {
                continue;
            }

            sum += number;
            count++;
        }

        if (count == 0)
        {
            return null;
        }

        return (double)sum / count;
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

    private static int ReadPositiveInteger(string name)
    {
        while (true)
        {
            Console.Write($"Enter {name}: ");

            if (int.TryParse(Console.ReadLine(), out var value) && value > 0)
            {
                return value;
            }

            Console.WriteLine("Invalid number. Enter a positive integer.");
        }
    }
}