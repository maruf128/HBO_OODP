using System;
class Animal
{
    public string Name, Sound;

    public Animal(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    public string MakeSound() => Sound;
}
class Person
{
    public string Name;
    public Animal Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }
    public string Info()
    {
        // maak een lege info aanzodat het niet fucked
        var info = "";
        if (Pet != null)
            info = $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
        else
        {
            // indien het wel null is doe dit
            info = $"{Name} has no pet";
        }
        return info;
    }
}
class Program
{
    public static void Main()
    {
        Animal pet = null;
        Person person1 = new Person("John Doe", pet);
        Console.WriteLine(person1.Info());

        pet = new Animal("Max", "Whoof!");
        Person person2 = new Person("Jane Doe", pet);
        Console.WriteLine(person2.Info());
    }
}