class Pet
{
    public string WhatAmI;
    public string Name;

    public Pet(string whatAmI, string name)
    {
        WhatAmI = whatAmI;
        Name = name;
    }
}
class Program
{
    static void Main()
    {
        var animals = new List<Pet> {
            // eerst dier dan naam/ deed eerst verkeerd
            new Pet("Dog", "Nugent"),
            new Pet("Cat","Steve"),
            new Pet("Goldfish", "Brutus")
        };
        // voor iedere dier in animals
        foreach (Pet animal in animals)
        {
            // print de listnaam en dan de variable uit die class
            Console.WriteLine($"I have a {animal.WhatAmI} named {animal.Name}");
        }
    }
}