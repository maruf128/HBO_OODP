Console.Write("Input string: ");
var str = Console.ReadLine();
var query = str
    .GroupBy(karakter => karakter) // group het eerst
    .Select(groep => new { Karakter = groep.Key, aantal = groep.Count() }) // selecteer uit de groep tekens een karakter =  ket en de aantal aan de count van de groep
    .OrderByDescending(item => item.aantal) // order het dan descending
    .FirstOrDefault(); // pak dat de eerste

Console.WriteLine($"{str} → '{query.Karakter}'");