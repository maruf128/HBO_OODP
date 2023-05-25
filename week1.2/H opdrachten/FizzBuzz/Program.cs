// vraag eerst een begin getal
Console.WriteLine("Vul het begin getal in ");
int begin_getal;
string BG = Console.ReadLine();
begin_getal = Convert.ToInt16(BG);

// vraag nu het eind getal
Console.WriteLine("Vul het begin getal in ");
int eind_getal;
string EG = Console.ReadLine();
eind_getal = Convert.ToInt16(EG);

// zet in een for loop print je elke nummer die tussen het begin getal en eind getal zitten included het begin en eind nummer
List<int> nummers = new List<int>();

// for iedere keer dat begin getal kleiner of gelijk blijft voeg je hem zo toe aan de lijst
for (int i = begin_getal; i <= eind_getal; i++)
{
    nummers.Add(i);
}
foreach (var number in nummers)
{
    // als het deel baar is door 5 en 3
    if (number % 3 == 0 && number % 5 == 0)
    {
        // dus hij is deelbaar door 3 en 5 print fizzbuzz
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 5 == 0)
    {
        // indien hij deelbaar door 5 is print buzz
        Console.WriteLine("Buzz");
    }
    else if (number % 3 == 0)
    {
        // indien hij deelbaar door 3 is print fizz
        Console.WriteLine("Fizz");
    }
    else
    {
        // niet deel baar door 3 en 5 print dan gwn de nummer
        Console.WriteLine(number);
    }
}