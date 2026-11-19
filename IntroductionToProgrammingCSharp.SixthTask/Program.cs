namespace IntroductionToProgrammingCSharp.SixthTask;

internal class Program
{
    private static void Main()
    {
        var temperatures = ReadMonthlyTemperatures();

        PrintTemperatureDifference(temperatures);
        PrintKelvinTemperatures(temperatures);
    }

    private static double Kelvin(double t) => t + 273.15;

    private static double[] ReadMonthlyTemperatures()
    {
        var days = ReadDayCount();
        var temperatures = new double[days];

        for (var i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = ReadCelsiusTemperature(i + 1);
        }

        return temperatures;
    }

    private static void PrintTemperatureDifference(double[] temperatures)
    {
        var min = temperatures[0];
        var max = temperatures[0];

        foreach (var temperature in temperatures)
        {
            if (temperature < min)
            {
                min = temperature;
            }

            if (temperature > max)
            {
                max = temperature;
            }
        }

        var difference = max - min;

        Console.WriteLine($"\nMinimum temperature: {min:F2} degrees Celsius");
        Console.WriteLine($"Maximum temperature: {max:F2} degrees Celsius");

        Console.WriteLine($"Difference in Celsius: {difference:F2} degrees Celsius");
        Console.WriteLine($"Difference in Kelvin: {difference:F2} Kelvin");
    }

    private static void PrintKelvinTemperatures(double[] temperatures)
    {
        Console.WriteLine("\nDaily temperatures in Kelvin:");

        for (var i = 0; i < temperatures.Length; i++)
        {
            var kelvin = Kelvin(temperatures[i]);

            Console.WriteLine($"Day {i + 1}: {kelvin:F2} K");
        }
    }

    private static int ReadDayCount()
    {
        while (true)
        {
            Console.Write("Enter number of days (1-31): ");

            if (int.TryParse(Console.ReadLine(), out var days) && days is >= 1 and <= 31)
            {
                return days;
            }

            Console.WriteLine("Invalid number of days. Try again.");
        }
    }

    private static double ReadCelsiusTemperature(int day)
    {
        while (true)
        {
            Console.Write($"Enter temperature for day {day} [-50, 50]: ");

            if (double.TryParse(Console.ReadLine(), out var temperature)
                && double.IsFinite(temperature)
                && temperature is >= -50 and <= 50)
            {
                return temperature;
            }

            Console.WriteLine("Invalid temperature. Try again.");
        }
    }
}
