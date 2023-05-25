// maak er een public class van zodat codegrade er makkelijk bij kan
public class Program
{
    public static void Main()
    {
        // hier roep je de functie aan en geef je de int mee
        Pow2(5);
    }

    public static int Pow2(int getal)
    // hier maak je de funtie en vraag je in de arguments om de int
    {
        // doe hier het getal keer zichzelf en dan return je het
        var square = getal * getal;
        return square;
    }
}
