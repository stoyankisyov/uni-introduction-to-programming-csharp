namespace IntroductionToProgrammingCSharp.ThirdTask;

internal class Program
{
    private static void Main()
    {
        var month = ReadMonth();

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("Spring");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Summer");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Autumn");
                break;
        }
    }

    private static int ReadMonth()
    {
        while (true)
        {
            Console.Write("Enter month number (1-12): ");
            
            if (int.TryParse(Console.ReadLine(), out var month) && month is >= 1 and <= 12)
            {
                return month;
            }

            Console.WriteLine("Invalid month. Try again.");
        }
    }
}