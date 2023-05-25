// variables om de game te spelen
int attack = 50;
double critChance = 0.33;
int bossHP = 1000;

// stel hier de random vast zodat je hem in de functie's kan gebruiken
Random random = new Random();

// je loopt dit todat de booshp lager is dan 0
while (bossHP > 0)
{
    // hiermee bereken je een kans zodat je critchange kan doen en meer damage doet
    double chance = random.NextDouble();
    // hier zet je de damage al op standaard je verdubbeld hem alleen als je crit mag doen
    int damage = attack;

    if (chance < critChance)
    {
        // indien het een crit is doe je 2x zoveel damage
        Console.WriteLine($"Damage: {damage}");
        damage *= 2;
    }
    // anders doen je gwn de normale damage
    bossHP -= damage;
    Console.WriteLine($"Damage: {damage}");
}
// print indien boos verslagen is
Console.WriteLine("Boss defeated!");
