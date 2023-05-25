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
class Person
{
    public string Name;
    public List<Pet> Pets;

    public Person(string name, List<Pet> pets)
    {
        Name = name;
        Pets = pets;
    }
}
class Program
{
    public static void Main()
    {
        var persoon = new Person("john", new List<Pet> {
            new Pet("Dog", "Nugent"),
            new Pet("Cat","Steve"),
            new Pet("Goldfish", "Brutus")
        });
        /* Create a Person named john with the following pets: done
         * - a Dog named Nugent done
         * - a Cat named Steve done
         * - a Goldfish named Brutus done
         * Then for each Pet, print John's name, what the Pet is and their name.
         */
        foreach (var pet in persoon.Pets)
        {
            // voor iedere dier print dit met de gebruikers naam
            Console.WriteLine($"{persoon.Name} has a {pet.WhatAmI} named {pet.Name}");
        }

    }
}