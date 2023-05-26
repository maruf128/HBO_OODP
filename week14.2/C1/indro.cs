// //Console.WriteLine("LINQ");
string[] names = { "piet", "jan", "klaas", "joop", "hans" };
// names.ToList().ForEach(name => Console.WriteLine(name));
// names.Where(name => name.StartsWith("j")).ToList().ForEach(name => Console.WriteLine(name));
// names.Select(name => "Naam is: " + name).ToList().ForEach(name => Console.WriteLine(name));
// names.Select(name => new { my_name = name }).ToList().ForEach(name => Console.WriteLine(name.my_name));

// // //OrderBy
// // //GroupBy
// // //Intersect
// // //Union
// // // LINQ expressions
IEnumerable<string> someNames =
    from name in names
    where name.StartsWith("j")
    select name;
Console.WriteLine(someNames);
someNames.ToList().ForEach(name => Console.WriteLine("LINQ expr: " + name));