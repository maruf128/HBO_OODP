// stell het hier alvast op een int zodat je het later niet hoeft te declareeren
int number = 0;

// vraag de heletijd totdat number tussen de 2 of 9 is
while (number < 2 || number > 9)
{
    Console.Write("Geef een getal tussen 2-9: ");
    // zodat het in codegrade goed komt? (was niet de fout)
    //Console.WriteLine();
    int.TryParse(Console.ReadLine(), out number);

    // indien getal kleiner dan 2 maak het 2
    if (number < 2)
    {
        number = 2;
    }
    // indien getal groter dan 9 maak het 9
    else if (number > 9)
    {
        number = 9;
    }
}

// dit zorgt ervoor dat je het verticale streepje krijgt in de console
Console.Write("  |");
for (int i = 1; i <= number; i++)
{
    Console.Write("{0,4}", i);
}
Console.WriteLine();
// hiermee maak je de header af
Console.WriteLine(new string('-', (number * 4) + 4));

// nu ga je de tabel invullen op basis van hoe lang het is en hoe groot het volgende getal zou moeten zijn
for (int i = 1; i <= number; i++)
{
    Console.Write("{0} |", i);
    for (int j = 1; j <= number; j++)
    {
        Console.Write("{0,4}", i * j);
    }
    Console.WriteLine();
}
