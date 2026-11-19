namespace IntroductionToProgrammingCSharp.FourthTask;

internal class Program
{
    private static void Main()
    {
        var n = ReadNumber("n");
        var k = ReadNumber("k");

        var product = 1;

        for (var i = 0; i <= k; i++)
        {
            var factor = n - i * k;
            product *= factor;
        }

        Console.WriteLine($"Product: {product}");
    }

    private static int ReadNumber(string name)
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