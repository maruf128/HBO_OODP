Console.Write("Input string: ");
var str = Console.ReadLine();
var query = from karakter in str
            group karakter by karakter into groep
            select new { Karakter = groep.Key, aantal = groep.Count() };

foreach (var item in query)
{
    Console.WriteLine($"Char [{item.Karakter}]: {item.aantal}");
}