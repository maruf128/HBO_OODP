// vraag voor de persoons naam
Console.WriteLine("What is the person's name?");
string name = Console.ReadLine();

// schrijf nu felicitatie's en telt zodat het niet te veel word
for (int i = 0; i < 4; i++)
{
    if (i == 2)
    {
        // indien je bij de 3de felicitatie bent gebruik je de naam
        Console.WriteLine("Happy birthday dear " + name + "!");
    }
    else
    {
        Console.WriteLine("Happy birthday to you!");
    }
}
