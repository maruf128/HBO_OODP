// declear de int met euro 
int euros = 4;

// dus terwijl je nog meer dan 0 euro hebt doe dit
while (euros > 0)
{
    // print eerst hoeveel geld de gebruiker over heeft
    Console.WriteLine($"Money left: {euros}");
    // vraag wat de gebruiker wilt doen 
    Console.WriteLine("Look around (1) or go in a ride (2)?");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        // aka rond kijken
        Console.WriteLine("Yay!");
    }
    else if (choice == "2")
    {
        // aka je gaat rond rijden
        Console.WriteLine("Wheee!");
        // zorgt ervoor dat er een euro word ingeleverd
        euros--;
    }
}

Console.WriteLine("Time to go home");
