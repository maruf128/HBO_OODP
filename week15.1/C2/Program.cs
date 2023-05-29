var array = new int[][] {
    new int[]{ 1, 2, 3, 4, 5 },
    new int[]{ 6, 7, 8, 9, 10 },
    new int[]{ 11, 12, 13, 14, 15 },
    new int[]{ 16, 17, 18, 19, 20 },
    new int[]{ 21, 22, 23, 24, 25 }
};
var qeury = from rij in Enumerable.Range(0, array.Length)
            from kolom in Enumerable.Range(0, array.Length)
            select new { Rij = kolom, Kolom = rij, Waarde = array[rij][kolom] };

int grootte = array.Length;
int[][] getransponeerd = new int[grootte][]; // maak een array met de groote van de vorige array
for (int i = 0; i < grootte; i++)
{
    // voor iedere lengte maar je een nieuwe int array
    getransponeerd[i] = new int[grootte];
}

foreach (var item in qeury)
{
    getransponeerd[item.Rij][item.Kolom] = item.Waarde;
}

// Print de geswitchde array
for (int rij = 0; rij < grootte; rij++)
{
    for (int kolom = 0; kolom < grootte; kolom++)
    {
        Console.Write($"{getransponeerd[rij][kolom]} ");
    }
    Console.WriteLine();
}