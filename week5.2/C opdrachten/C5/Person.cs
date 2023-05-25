public class Person
{
    private string _firstname;
    private string _lastname;

    public Person(string naam, string achternaam)
    {
        _firstname = naam;
        _lastname = achternaam;
    }
    public string FullName
    {
        get { return _firstname + " " + _lastname; }
    }
}