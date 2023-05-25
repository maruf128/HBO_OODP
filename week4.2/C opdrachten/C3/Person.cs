public class Person
{
    public string Name;
    public int Age;
    public Person()
    {
    }
    public Person(string naam)
        : this()
    {
        this.Name = naam;
    }

    public Person(string naam, int leeftijd)
    : this(naam)
    {
        Age = leeftijd;
    }
}