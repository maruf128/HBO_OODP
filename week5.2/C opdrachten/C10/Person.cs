class Person
{
    public Person(string name, int age)
    {
        Name = name;
        _age = age;
    }

    public string Name { get; set; }

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 130)
            {
                _age = 0;
            }
            else if (value < 0)
            {
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }


    public string Info { get => $"{Name} is {Age} years old"; }
}