class Program
{
    public static void Main()
    {
        // maak de strings aan zodat je in de while loop kan kijken of ze leeg zijn (krijg wel warnings hierdoor)
        string name1 = "";
        string name2 = "";
        string name3 = "";
        // schrijf een while loop om de warnings weg te werken
        while (string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2) || string.IsNullOrEmpty(name3))
        {
            // geef aan dat ze 3 namen moeten geven
            Console.WriteLine("Give three names.");

            // kijk nu per naam of het leeg is, zo ja vraag het om in te vullen
            if (string.IsNullOrEmpty(name1))
            {
                Console.WriteLine("The first name:");
                name1 = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(name2))
            {
                Console.WriteLine("The second name:");
                name2 = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(name3))
            {
                Console.WriteLine("The third name:");
                name3 = Console.ReadLine();
            }
        }

        // nu roep je de functie aan en geef je de 3 variables mee en kijk je welke functie de langste is
        Console.WriteLine($"{Longest(name1, name2, name3)} has the longest name");
    }

    public static string Longest(string s1, string s2, string s3)
    {
        // indien naam 1 de langste is return het dan
        if (s1.Length > s2.Length && s1.Length > s3.Length) return s1;
        // indien naam 2 de langste is
        if (s2.Length > s1.Length && s2.Length > s3.Length) return s2;
        // indien naam 3 de langste is
        if (s3.Length > s1.Length && s3.Length > s2.Length) return s3;
        // maar indien 2 of alle 3 dezelfde lengte hebben return dit:
        return "Two or more names have the same length.";
    }
}
// ik moest toevoegen dat ik na check of een naam wel een value had voor de warnings