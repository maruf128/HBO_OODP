// zelfde code sinds ik toen al for each gebruikte
List<double> listOfDoubles = new List<double>();

// voeg alle cijfers toe aan het lijstje
listOfDoubles.Add(7);
listOfDoubles.Add(5.5);
listOfDoubles.Add(3.2);
listOfDoubles.Add(10);
listOfDoubles.Add(4.5);

// maak een variable waar je telt hoeveel studenten zijn geslaagd
int geslaagd = 0;
// er zijn makkelijkere manieren om te zien hoeveel items in een list zitten maar ik doe het zo
int leerlingen = 0;
// maak een for loop om iedere cijfer at least 5.5 is
foreach (double x in listOfDoubles)
{
    //Console.WriteLine(x);
    if (x >= 5.5)
    {
        geslaagd++;
    }
    // voor iedere grade is een leerling dus zo tel ik de aantal studenten op
    leerlingen++;
}

// zodra je klaar bent print hoeveel mensen zijn geslaagd
Console.WriteLine($"{geslaagd} out of {leerlingen} students passed");