public class Person : IEquatable<Person>
{
    // plaats de gegeven property's
    public string Name { get; set; }
    public int Age { get; set; }

    public bool Equals(Person item)
    {
        if (item == null) // aka hij is leeg
        {
            return false;
        }
        // kijk of het gelijk is
        if (this.Name == item.Name && this.Age == item.Age)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override bool Equals(object item)
    {
        if (item == null)
        {
            return false;
        }
        if (item is Person)
        {
            // dus als het een persoon is roep dan allen de andere equals aan
            Person person = (Person)item; // maak er een person object van
            return Equals(person); // return the result of the call to Equals(Person item) method
        }
        return false;
    }

    public override string ToString()
    {
        string text = $"{Name} ({Age})";
        return text;
    }
}