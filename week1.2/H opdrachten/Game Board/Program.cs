// Maak alvast de int
int grootte = 0;
while (grootte < 2)
{
    // Vraag hier voor de grootte
    Console.WriteLine("Geef de grootte van het spelbord op (minimaal 2):");
    grootte = Convert.ToInt32(Console.ReadLine());
}

// Voor iedere lengte ga je nu een W of B schrijven
for (int i = 0; i < grootte; i++)
{
    for (int j = 0; j < grootte; j++)
    {
        // indien hij ook gelijk even is dan ga je de W schrijven anders de B
        if ((j + i + (grootte % 2)) % 2 == 0)
        {
            Console.Write("W");
        }
        else
        {
            Console.Write("B");
        }
    }
    Console.WriteLine();
}
