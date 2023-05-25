using System;
public class DoubleToInt
{
    public static void Main()
    {
        // stel hier de variavble vast
        double nummer = 12.34;

        // stel hier de variables aan en op basis van truncated nummer aka de euro bereken je de centen
        int euro = (int)Math.Truncate(nummer);
        int cent = (int)Math.Round(100 * Math.Abs(nummer - euro));
        if (cent == 100) { cent = 0; euro += (nummer < 0) ? -1 : 1; }
        // nu print je het
        Console.WriteLine($"Euros: {euro}");
        Console.WriteLine($"Cents: {cent}");
    }
}