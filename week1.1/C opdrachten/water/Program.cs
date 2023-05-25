// vraag eerst naar de graden van het water
Console.WriteLine("What is the temperature of the water? (Celsius)");
// zet nu de leeftijd in een variable om het later te gebruiken
double temperatuur;
string temp = Console.ReadLine();
temperatuur = Convert.ToDouble(temp);
// Console.WriteLine(eigen_leeftijd); (hiermee kan je de leeftijd printen)

// schrijf een if else statement om erachter te komen welke soort staat het heeft S,L,G
if (temperatuur <= 0)
{
    // indien het water solid is dan is het onder 0 graden is of 0
    Console.WriteLine("At " + temperatuur + " degrees Celsius, the water will be solid");
}
else if (temperatuur >= 100)
{
    // indien het water gas is dan is het boven de 100 graden of 100
    Console.WriteLine("At " + temperatuur + " degrees Celsius, the water will be gas");
}
else if (temperatuur > 0 || temperatuur < 100)
{
    // indien het water liquid is dan is het boven 0 graden en onder 100 graden
    Console.WriteLine("At " + temperatuur + " degrees Celsius, the water will be liquid");
}


// || = of