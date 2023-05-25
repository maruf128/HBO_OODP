// vraag naar de balance
Console.WriteLine("Voer je balance in");
double balance;
string B = Console.ReadLine();
balance = Convert.ToDouble(B);

// vraag naar de interesses
double interesses;
Console.WriteLine("hoeveel intrest");
string Int = Console.ReadLine();
interesses = Convert.ToDouble(Int);
interesses = 100 + interesses;

// vraag aantal jaren dat je wilt berekenen
int jaren;
Console.WriteLine("hoe lang");
string years = Console.ReadLine();
jaren = Convert.ToInt32(years);

// maak var tax aan om belasting bij te houden
double tot_tax = 0;
// bereken voor elk jaar
for (int i = 1; i <= jaren; i++)
{
    // maak de nu tax 0 om het te herbruiken
    double nu_tax = 0;
    // zorg eerst dat je nieuwe bedrag weet na intresse
    balance = balance / 100 * interesses; // nu weet je nieuwe bedrag na 1 jaar aantal procent erbij

    // tax regel alleen als het balance meer is dan 50K
    if (balance >= 50000)
    {
        // ga veder indien het meer is dan 100K
        if (balance >= 100000)
        {
            // meer dan 100K
            double hoogste = balance - 100000;
            // over dit bedrag betaal je 3%
            nu_tax += hoogste / 100 * 3;
            // sinds je automatisch nu 100.000 over zou moeten hebben bereken je 50K tax
            nu_tax += 50000 / 100 * 1.5;
        }
        else
        {
            // anders bereken je alleen onder de 50K
            double lager = balance - 50000;
            // je hebt nu over wat meer dan 50K is
            nu_tax += lager / 100 * 1.5;
        }
    }
    // zodra je alle taxes heb berekent
    // haal de nu tax van je balace eraf zodat je betaald hebt
    balance -= nu_tax;
    // en voeg de nu tax toe aan de totale tax
    tot_tax += nu_tax;

}

// print uitkomst
int Eind_balance = (int)balance;
int Eind_tax = (int)tot_tax;
Console.WriteLine($"Balance after {jaren} years: {Eind_balance}");
Console.WriteLine($"Amount of taxes paid: {Eind_tax}");
