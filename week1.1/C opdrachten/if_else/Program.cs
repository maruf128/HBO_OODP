// vraag voor de gebruikers leeftijd
Console.WriteLine("What is your age? ");
// zet nu de leeftijd in een variable om het later te gebruiken
int eigen_leeftijd;
string E_L = Console.ReadLine();
eigen_leeftijd = Convert.ToInt16(E_L);
// Console.WriteLine(eigen_leeftijd); (hiermee kan je de leeftijd printen)

// vraag nu de leeftijd van de partner
Console.WriteLine("What is the age of the student next to you? ");
// zet nu de leeftijd in een variable om het later te gebruiken
int partner_leeftijd;
string P_L = Console.ReadLine();
partner_leeftijd = Convert.ToInt16(P_L);
// Console.WriteLine(partner_leeftijd); (hiermee kan je de leeftijd printen)

// maak een if else statement om te kijken of de gebruiker even oud, ouder of jonger is dan de partner
if (eigen_leeftijd == partner_leeftijd)
{
    // indien jullie dezelfde leeftijd
    Console.WriteLine("Your ages are equal");
}
else if (eigen_leeftijd > partner_leeftijd)
{
    // indien je ouder bent
    Console.WriteLine("You are older");
}
else if (eigen_leeftijd < partner_leeftijd)
{
    // indien je jonger bent
    Console.WriteLine("You are younger");
}