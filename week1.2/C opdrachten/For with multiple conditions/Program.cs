int attempts = 3;
bool correct = false;

// voor iedere attempt die je hebt en correct is true
for (; attempts > 0 && !correct; attempts--)
{
    // vraag hier voor de pincode
    Console.WriteLine("Enter the PIN code:");
    string pin = Console.ReadLine();

    if (pin == "1234")
    {
        // indien correct stop de while loop
        correct = true;
        Console.WriteLine("Correct!");
    }
    else
    {
        // indien fout -1 bij attempts
        Console.WriteLine($"{attempts} attempts left.");
        Console.WriteLine($"{attempts} attempts left.");
    }
}

if (attempts == 0)
{
    // indien je attempts voorbij zijn
    Console.WriteLine("Your pass is confiscated.");
}
