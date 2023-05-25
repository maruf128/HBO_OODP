// vraag eerst naar de hoeveel 
Console.Write("Enter the amount to be paid: ");
string input = Console.ReadLine();
int geld = int.Parse(input);
// maak hier een int aan zodat je later makkelijk kan bij houden hoeveel geld je iedere keer betaalt
int betaald = 0;
// zet het false zodat de while loop door blijft lopen
bool isbetaald = false;

while (!isbetaald)
{
    // vraag nu todat alles betaald is hoeveel hij/zij wilt betalen
    Console.WriteLine("1: 5");
    Console.WriteLine("2: 10");
    Console.WriteLine("3: 20");
    Console.WriteLine("4: 50");
    Console.Write("Pay how much? ");

    input = Console.ReadLine();
    int option = 0;
    // hier check je of de input die gegeven wel een nummer is
    // en in option bewaar je dan de getal die doorgegeven is
    if (int.TryParse(input, out option))
    {
        // voor iedere nummer word de juiste waarde geteld bij paidamount
        if (option == 1)
        {
            betaald += 5;
        }
        else if (option == 2)
        {
            betaald += 10;
        }
        else if (option == 3)
        {
            betaald += 20;
        }
        else if (option == 4)
        {
            betaald += 50;
        }

        if (betaald >= geld)
        {
            // wnr je meer betaald hebt of gelijk heb betaald gooi je de while loop true zodat hij stopt
            isbetaald = true;
        }
    }
}

// zodra je meer betaald hebt dan dat het koste gebeurd dit
if (betaald > geld)
{
    // vraag of de gebruiker het geld wilt geven als tip
    int teveel = betaald - geld;
    Console.Write($"You paid {teveel} too much. Give a tip? y/n");
    input = Console.ReadLine();
    // indie het dus geen Y of N is in lower case getransformeerd. geef aan dat het geen juiste waarde is en vraag het telkesn
    while (input.ToLower() != "y" && input.ToLower() != "n")
    {
        Console.Write("Invalid input. Do you want to give the rest as a tip (y/n)? ");
        input = Console.ReadLine();
    }
    // wnr het wel een y of n is
    if (input.ToLower() == "y")
    {
        // ja je wilt het als tip geven
        Console.WriteLine("You have paid " + betaald);
    }
    else if (input.ToLower() == "n")
    {
        // nee je wilt het niet al tip geven
        Console.WriteLine("You have paid " + geld);
    }
}
else if (betaald == geld)
{
    // indien je precies heb betaald
    Console.WriteLine("You have paid " + geld);
}
