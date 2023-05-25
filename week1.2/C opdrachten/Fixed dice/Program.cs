using System;

class Program
{
    static void Main()
    {
        // hiermee maak je de random aan zodat je hem kan gebruiken in de for loop
        Random random = new Random(1);
        // maak hier een loop aan en indien het 10 keer is gerepeat stopt het
        for (int i = 0; i < 10; i++)
        {
            // hiermee vind je een random nummer
            int randomNumber = random.Next(1, 7);
            Console.WriteLine(randomNumber);
        }
    }
}
