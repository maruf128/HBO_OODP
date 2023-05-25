using System;

public class Program
{
    public static void Main()
    {
        Console.Write("vul een getal in: ");
        int getal = Int32.Parse(Console.ReadLine());

        int result = RecursiveSum(getal);
        Console.WriteLine(result);
    }

    public static int RecursiveSum(int n)
    {
        if (n < 0) // indien het een negatief getal is
        {
            return 0;
        }
        else // return de heletijd het getal todat het klaar is
        {
            return n + RecursiveSum(n - 1);
        }
    }
}
