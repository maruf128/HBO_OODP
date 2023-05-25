// laat de gebruiker eerst zien wat de keuzes zijn
Console.WriteLine("What direction would you like to go?");
Console.WriteLine("Up");
Console.WriteLine("Down");
Console.WriteLine("Right");
Console.WriteLine("Left");
string antwoord = Console.ReadLine();
string choice = antwoord.ToLower();
int y = 0;
int x = 0;

// passing string "str" in
// switch statement
switch (choice)
{

    case "up":
        y = +1;
        Console.WriteLine("Current position");
        Console.WriteLine("X:" + x + ", Y:" + y);
        break;

    case "down":
        y = -1;
        Console.WriteLine("Current position");
        Console.WriteLine("X:" + x + ", Y:" + y);
        break;

    case "right":
        x = +1;
        Console.WriteLine("Current position");
        Console.WriteLine("X:" + x + ", Y:" + y);
        break;

    case "left":
        x = -1;
        Console.WriteLine("Current position");
        Console.WriteLine("X:" + x + ", Y:" + y);
        break;
    default:
        Console.WriteLine("Nothing");
        break;
}