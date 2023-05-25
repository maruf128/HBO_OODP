class Player
{
    // stell hier de variables vast zodat je ze straks kan invullen
    public string Name { get; set; }
    public int HealthPoints { get; set; }
    public int Power { get; set; }

    public Player(string name, int power)
    {
        Name = name;
        Power = power;
        // zet hier de health points vast
        HealthPoints = 100;
    }

    // indien is alive return dat de hp meer is dan 0
    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    // indien hp minder dan 0 word geef het een 0
    public void TakeDamage(int damage)
    {
        HealthPoints -= damage;
        if (HealthPoints < 0)
        {
            HealthPoints = 0;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // geef hier de naam en damage mee
        Player p1 = new Player("John Snow", 30);
        Player p2 = new Player("Night King", 60);

        Player winner = null;
        // terwijl er geen winner is doe dit
        while (winner == null)
        {
            // voer de hele tijd de functie uit
            p1.TakeDamage(p2.Power);
            p2.TakeDamage(p1.Power);


            // en check of ze nog leven
            if (!p1.IsAlive())
            {
                winner = p2;
            }
            else if (!p2.IsAlive())
            {
                winner = p1;
            }
        }

        // uiteindelijk print de winner
        Console.WriteLine($"Winner is {winner.Name}");
    }
}
