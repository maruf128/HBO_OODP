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
    public override string ToString()
    {
        string text = $"{Name} ({Age})";
        return text;
    }
}