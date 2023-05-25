class Program
{
    public static void Main()
    {
        // hier roep je de functie aan en geef je 2 string values mee
        PrintFullName("John", "Doe");
    }

    public static void PrintFullName(string firstName, string lastName)
    // hier maak je de funtie en vraag je in de arguments om 2 strings
    {
        // hier schrijf je de values uit naast elkaar die je hebt ontvangen
        Console.WriteLine(firstName + " " + lastName);
    }
}
