public static class Program
{
    public static bool IsDivisibleBy(int jaar, int gedeelt)
    {
        // return of je de nummer kan delen door 4
        return jaar % gedeelt == 0;
    }

    public static bool IsLeapYear(int jaar)
    {
        // return of het een leap year is door de is divisible functie aan te roepen en doe dit door 4, 100 en 400
        return (IsDivisibleBy(jaar, 4));
    }

    public static void PrintIsLeapYear(int jaar)
    {
        if (IsLeapYear(jaar))
        {
            // indien alles true is doe dit
            Console.WriteLine(jaar + " is a leap year");
        }
        else
        {
            // anders is het geen leap year
            Console.WriteLine(jaar + " is not a leap year");
        }
    }

    public static void Main()
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
        PrintIsLeapYear(2100);

        Console.ReadLine();
    }
}

