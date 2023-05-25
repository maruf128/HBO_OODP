class Person // base clas
{
    public string Name;
    public Person(string name) => Name = name;

    public string Introduce() => $"I am {Name}";
}