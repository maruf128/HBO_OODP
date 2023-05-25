
class Program
{
    static void Main(string[] args)
    {
        // begin de eerste keer
        Console.WriteLine("Time to play Guess The Number!");
        while (true)
        {
            raadnummer();
            // vraag nu of ze nog een ronde willen zo ja dan begin je weer bij de while loop
            Console.WriteLine("Do you wish to play another round? Y to continue");
            var opnieuw = Console.ReadLine();
            var keuze = opnieuw.ToLower();
            // indien het iets anders is end je de game
            if (keuze != "y")
            {
                // indien het niet gelijk is aan Y
                Console.WriteLine("Thank you for playing!");
                break;
            }
        }
    }
    static void raadnummer()
    {
        // vraag voor de minimale getal
        Console.WriteLine("Give the minimum number:");
        int klein = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give the maximum number:");
        int groot = Convert.ToInt32(Console.ReadLine());

        // kijk of de kleine groter is dan de grote, switch ze dan
        if (klein > groot)
        {
            // indien je de getallen moet switchen
            Console.WriteLine("The minimum is higher than the maximum. Switching values.");
            int vervang = klein;
            klein = groot;
            groot = vervang;
        }

        // kijk of ze even groot zijn
        if (klein == groot)
        {
            // zo ja add 1 bij groot
            Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
            groot++;
        }

        // maak hier een random aan
        // navragen waarom random fout gaat
        Random rand = new Random(0);
        // hier is de random getal op basis van de kleine en grote
        int guess = rand.Next(klein, groot + 1);

        // maak hem hier alvast aan zodat je het alsnog in de while loop kan vragen en dan het in codegrade goed komt
        var userGuess = 0;
        // kijk of het gelijk is todat het gelijk is
        while (userGuess != guess)
        {
            // schrijf dat de gebruiker kan raden
            Console.WriteLine($"Guess the number [{klein}-{groot}]");
            // schrijf hier op wat de getal is dat de user had
            userGuess = Convert.ToInt32(Console.ReadLine());
            // indien het te groot is
            if (userGuess > guess)
            {
                // schrijf lower
                Console.WriteLine($"Lower!");

            }
            else if (userGuess < guess)
            {
                // anders
                Console.WriteLine($"Higher!");
            }
            Console.WriteLine($"getal dat geraden moet worden {guess}");

        }

        Console.WriteLine($"{userGuess} is correct!");
    }
}