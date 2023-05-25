abstract class Person
{
    public int Age { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }

    public Person(string naam, string achternaam, int leeftijd)
    {
        FirstName = naam;
        LastName = achternaam;
        Age = leeftijd;
    }
    public abstract string Greet();
    public virtual string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

}