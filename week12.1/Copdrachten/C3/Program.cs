using System;

public class Program
{
    public static void Main()
    {
        Console.Write("vul een getal1 in: ");
        int getal1 = Int32.Parse(Console.ReadLine());
        Console.Write("vul een getal2 in: ");
        int getal2 = Int32.Parse(Console.ReadLine());
        int result = RecursiveLog(getal1, getal2);
        Console.WriteLine($"{result}");
    }

    public static int RecursiveLog(int num, int logBase)
    {
        // base case
        if (num < logBase)
        {
            return 0;
        }
        else
        {
            return 1 + RecursiveLog(num / logBase, logBase);
        }
    }
}
