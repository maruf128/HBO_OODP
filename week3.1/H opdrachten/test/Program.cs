int rolls = 5;
int sides = 6;
for (int i = 1; i <= rolls; i++)
{
    Random r = new Random();
    int random_dice = r.Next(0, sides + 1);
    Console.WriteLine($"Roll {i}: {random_dice}");
    // aka voor iedere roll doe dit

}

//indien het false is
List<int> mogelijkheden = new List<int>();
for (int i = 1; i <= sides; i++)
{
    // nu voeg je elke side dat er is aan de list
    mogelijkheden.Add(i);
}

// maak de lijst met alle gerolde getallen
List<int> gerolled = new List<int>();
for (int i = 1; i <= rolls; i++)
{
    Random r = new Random();
    int random_dice = r.Next(1, sides + 1);
    gerolled.Add(random_dice);
}

// nu join je de 2 lijsten en vergelijk je hoe vaak het voorkomt
var g = mogelijkheden.GroupJoin(gerolled,
                                s => s,
                                r => r,
                                (s, rs) => new { Side = s, Count = rs.Count() });

// en hier print je voor iedere getal hoevaak het voorkomt
foreach (var grp in g)
{
    Console.WriteLine("{0} was rolled {1} times", grp.Side, grp.Count);
}