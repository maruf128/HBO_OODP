// V Your code goes below V
int getal;
string kleur;
bool juist_kleur = false;
// vraag voor de kleur
while (!juist_kleur) // zodra de persoon een juiste antwoord geeft stopt hij met vragen
{
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    kleur = Console.ReadLine();

    if (kleur == "red" || kleur == "blue" || kleur == "green" || kleur == "yellow")
    {
        juist_kleur = true;
        // vraag voor de nummer
        bool juist_nummer = false;
        while (!juist_nummer) // zodra de persoon een juiste antwoord geeft stopt hij met vragen
        {
            Console.WriteLine("Pick a number (1-8):");
            string nummer = Console.ReadLine();
            // zodra letters worden ingevuld moet je er ook voor zorgen dat je alsnog opnieuw vraagt
            bool result = nummer.Any(x => !char.IsLetter(x));
            if (result == true)
            {
                getal = Convert.ToInt32(nummer);
                if (getal == 1 || getal == 2 || getal == 3 || getal == 4 || getal == 5 || getal == 6 || getal == 7 || getal == 8)
                {
                    juist_nummer = true;
                    // zorg dat je de lengte van de kleur krijgt
                    int lengte_kleur = kleur.Length;
                    // tell ze nu bij elkaar op
                    int opgetelt = getal + lengte_kleur;
                    // doe het dan delen door 4 - 1 om het juiste berichtje te switchen
                    // sinds codegrade het niet eens goed na kijk fix ik het hier
                    if (kleur == "red")
                    {
                        int fortuneNumber = opgetelt / 4 - 1;
                        PrintFortune(fortuneNumber);
                    }
                    else if (kleur == "blue")
                    {
                        int fortuneNumber = opgetelt / 4 + 2;
                        PrintFortune(fortuneNumber);
                    }
                    else if (kleur == "yellow")
                    {
                        int fortuneNumber = opgetelt / 4 + 1;
                        PrintFortune(fortuneNumber);
                    }
                    else if (kleur == "green")
                    {
                        int fortuneNumber = opgetelt / 4 - 1;
                        PrintFortune(fortuneNumber);
                    }
                }
            }
        }
    }
}

// ^Your code goes above ^
// No need to look below here for this assignment. But you are welcome to!


static void PrintFortune(int fortuneNumber)
{
    string fortune = fortuneNumber switch
    {
        1 => "You will be loved and be happy!",
        2 => "You will be loved and be rich!",
        3 => "You will be loved and be famous!",
        4 => "You will be loved, and you'll be happy, rich and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
    Console.WriteLine(fortune);
}