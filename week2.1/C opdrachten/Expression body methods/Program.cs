class Program
{
    public static void Main()
    {
        // vraag eerst voor de voor en achternaam
        Console.WriteLine("Vul hier je voornaam in");
        string voornaam = Console.ReadLine();
        Console.WriteLine("vul hier je achternaam in");
        string achternaam = Console.ReadLine();
        // roep nu de display functie aan 
        DisplayName(voornaam, achternaam);
    }

    public static string Name(string voornaam, string achternaam) => voornaam + " " + achternaam;// in deze functie maak je de print resultaat

    public static void DisplayName(string voornaam, string achternaam) => Console.WriteLine(Name(voornaam, achternaam));// in deze functie geef je de values door naar name zodat je ze daar kan printen
}
