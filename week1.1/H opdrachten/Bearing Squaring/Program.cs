// vraag eerst een voor een of de gebruiker die richting op wil gaan
Console.WriteLine("Is North a valid direction? (Y/N)");
string north = Console.ReadLine();

Console.WriteLine("Is East a valid direction? (Y/N)");
string east = Console.ReadLine();

Console.WriteLine("Is South a valid direction? (Y/N)");
string south = Console.ReadLine();

Console.WriteLine("Is West a valid direction? (Y/N)");
string west = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("From here you can go: ");
Console.WriteLine();

// indien Y voor north aanstaat teken dan de compas gedeelte voor noord
if (north.ToUpper() == "Y")
{
    Console.WriteLine("    N");
    Console.WriteLine("    |");
}

// check of een van de west of east aanstaat
if (west.ToUpper() == "Y" || (east.ToUpper() == "Y"))
{
    // kijk eerst of ze beide aanstaan
    if (west.ToUpper() == "Y" && (east.ToUpper() == "Y"))
    {
        Console.WriteLine("W---|---E");
    }
    else if (west.ToUpper() == "Y")
    {
        Console.WriteLine("W---|");
    }
    else if (east.ToUpper() == "Y")
    {
        Console.WriteLine("    |---E");
    }

}
else
{
    //aka beide staan niet aan
    Console.WriteLine("    |");
}


// indien Y voor south aanstaat teken dan de compas gedeelte voor zuid
if (south.ToUpper() == "Y")
{
    Console.WriteLine("    |");
    Console.WriteLine("    S");
}



// vraag nu de bearing (angel)
Console.WriteLine();
int bearing = int.Parse(Console.ReadLine());

// indien hij te veel is haal 360 ervan af om het een normale getal te geven, en dit doe je todat het kleiner of gelijk aan 360 is
while (bearing >= 360)
{
    bearing -= 360;
}

// en indien bearing getal onder de 45 is doe je plus 360 todat het 45 of boven de 45 is
while (bearing < 45)
{
    bearing += 360;
}
// indien het 45 of hoger is en kleiner dan 135 ga je noord 

// indien het hoger is dan 45 en 135 of kleiner is dan ga je oost
if (bearing > 45 && bearing <= 135)
{
    if (east.ToUpper() == "Y")
    // indien Y aanstaat, staat er of je die richting wel op kan
    {
        Console.WriteLine("You are going east");
    }
    else
    {
        Console.WriteLine("You can't go east");
    }
}
// indien het groter is dan 135 of 225 of kleiner dan ga je zuid
else if (bearing > 135 && bearing <= 225)
{
    if (south.ToUpper() == "Y")
    // indien Y aanstaat, staat er of je die richting wel op kan
    {
        Console.WriteLine("You are going south");
    }
    else
    {
        Console.WriteLine("You can't go south");
    }
}
// indien het groter is dan 225 en 315 of kleiner dan ga je westen
else if (bearing > 225 && bearing <= 315)
{
    if (west.ToUpper() == "Y")
    // indien Y aanstaat, staat er of je die richting wel op kan
    {
        Console.WriteLine("You are going west");
    }
    else
    {
        Console.WriteLine("You can't go west");
    }

}
else if (bearing >= 45 && bearing < 315)
{
    // indien Y aanstaat, staat er of je die richting wel op kan
    if (north.ToUpper() == "Y")
    {
        Console.WriteLine("You are going north");
    }
    else
    {
        Console.WriteLine("You can't go north");
    }
}
// deze is hier om codegrade te fixen zodat 320 wel iets aangeeft
else if (bearing > 315)
{
    if (north.ToUpper() == "Y")
    {
        Console.WriteLine("You are going north");
    }
    else
    {
        Console.WriteLine("You can't go north");
    }
}
Console.WriteLine(bearing);