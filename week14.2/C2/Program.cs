
string[] persons = new string[] { "Dave", "John", "Peter", "Johanna", "Bart", "Henk", "Marie" };
string[] students = new string[] { "Dave", "Micheal", "Roxanne", "Johanna", "John", "Bart", "Henk" };

Console.WriteLine("These names are in both datasets:");
// maak query eerst
persons.Intersect(students).ToList().ForEach(name => Console.WriteLine(name));



Console.WriteLine();
Console.WriteLine("These names are unique:");
var query = students.Union(persons);
query.Distinct().OrderBy(distinct => distinct).ToList().ForEach(number => Console.WriteLine(number));
