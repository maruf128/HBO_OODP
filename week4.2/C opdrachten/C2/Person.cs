public class Person
{
    public string Name;
    public int Age;
    public Person(string naam, int leeftijd)
    {
        Name = naam;
        Age = leeftijd;
    }
    public Person(string naam)
    {
        Name = naam;
        Age = 0;
    }
}