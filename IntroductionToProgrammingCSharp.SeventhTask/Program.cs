namespace IntroductionToProgrammingCSharp.SeventhTask;

internal class Program
{
    private static void Main()
    {
        var settlements = ReadSettlementNames();

        PrintTwoWordSettlementNames(settlements);
    }

    private static string[] ReadSettlementNames()
    {
        var count = ReadSettlementCount();
        var settlements = new string[count];

        for (var i = 0; i < settlements.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter settlement {i + 1}: ");

                var name = Console.ReadLine()?.Trim();

                if (!string.IsNullOrWhiteSpace(name) && char.IsUpper(name[0]))
                {
                    settlements[i] = name;
                    
                    break;
                }

                Console.WriteLine("Invalid name. It must start with a capital letter.");
            }
        }

        return settlements;
    }

    private static void PrintTwoWordSettlementNames(string[] settlements)
    {
        Console.WriteLine("\nSettlements with exactly two words:");

        var found = false;

        foreach (var settlement in settlements)
        {
            var words = settlement.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 2)
            {
                Console.WriteLine(settlement);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching settlements found.");
        }
    }

    private static int ReadSettlementCount()
    {
        while (true)
        {
            Console.Write("Enter number of settlements (1-50): ");

            if (int.TryParse(Console.ReadLine(), out var count) && count is >= 1 and <= 50)
            {
                return count;
            }

            Console.WriteLine("Invalid count. Enter a number between 1 and 50.");
        }
    }
}