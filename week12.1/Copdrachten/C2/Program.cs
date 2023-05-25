using System;

public class Program
{
    public static void Main()
    {
        Console.Write("vul een getal in: ");
        int getal = Int32.Parse(Console.ReadLine());

        int result = Factorial(getal);
        Console.WriteLine(result);
        Console.WriteLine("{0} factorial is {1}", getal, result);
    }

    public static int Factorial(int n)
    {
        if (n < 0) // indien het een negatief getal is
        {
            return -1;
        }
        else if (n == 0) // base case
        {
            return 1;
        }
        else // return de heletijd het getal todat het klaar is
        {
            return n * Factorial(n - 1);
        }
    }
}
