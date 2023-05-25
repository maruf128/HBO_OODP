class Program
{
    public static void Main()
    {
        // stel hier max hp en curr hp vast
        int maxHP = 10;
        int currHP = 5;

        // hier maak je de currhp gelijk aan een functie waar je de 2 values hierboven mee geeft
        currHP = DrinkPotion(currHP, maxHP);
        // en dan print je de status van de variable
        DisplayStatus(currHP);

        // hier maak je de currhp gelijk aan een functies waarbij je de current hp mee geeft en hoeveel dmg je krijgt
        currHP = TakeDamage(currHP, 15);
        DisplayStatus(currHP);
    }

    public static string DisplayStatus(int currHP)
    {
        // hier schrijf je hoeveel hp je hebt, indien currHP kleiner is dan 0 of gelijk aan 0 ben je dood anders print je het getal van je curr hp
        Console.WriteLine($"Current HP: {currHP}{(currHP <= 0 ? " (Dead)" : "")}");
        return $"Current HP: {currHP}{(currHP <= 0 ? " (Dead)" : "")}";
    }

    public static int DrinkPotion(int currHP, int maxHP) => Minimum(currHP + 10, maxHP);
    public static int TakeDamage(int currHP, int damage) => Maximum(currHP - damage, 0);

    public static int Minimum(int n1, int n2) => n1 < n2 ? n1 : n2;
    public static int Maximum(int n1, int n2) => n1 > n2 ? n1 : n2;
}

// errors, zo wie zo waren veel methods value niet correct dus maakt het naar een int, ook moest ik de return value correct maken
// maar idk of codegrade een return wel fijn vind
// was de print vergeten 
