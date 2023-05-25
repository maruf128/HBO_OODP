// een extra security om te kijken 
bool confirmed = false;

// dus while niet false 
while (!confirmed)
{
    // vraag of de gebruiker zeker is om de file te deleten
    Console.WriteLine("Really delete this file? (y/n)");
    string answer = Console.ReadLine();

    if (answer == "y")
    {
        // indien ja zet confirmed op true en verwijder
        confirmed = true;
        Console.WriteLine("File deleted");
    }
    else if (answer == "n")
    {
        // indien nee zet confirmed op true en verwijder niet
        confirmed = true;
        Console.WriteLine("File not deleted");
    }
}
