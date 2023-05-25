class Bicycle
{
    public Person Owner;
    public readonly string FrameNumber; // na code checken kan alles behalve framenumber aangepast worden
    public int CurrentGear;
    public string Color;

    public Bicycle(Person owner, string number, string color)
    {
        Owner = owner;
        FrameNumber = number;
        Color = color;
        CurrentGear = 1;
    }

    public void ChangeOwner(Person newOwner) => Owner = newOwner;
    public void ChangeGear(int gear) => CurrentGear = gear;
    public void Paint(string color) => Color = color;
}
class Person
{
    public readonly string Name; // in deze class word naam nog niet aangepast dus kan je hem ook readonly zetten
    public int Age;

    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    public void GrowOlder() => Age++;
}
class Program
{
    public static void Main()
    {
        var john = new Person("John Doe");
        for (int i = 0; i < 5; i++)
            john.GrowOlder();
        var bicycle = new Bicycle(null, "abc123", "Red");
        bicycle.Paint("Blue");
        bicycle.ChangeOwner(john);
        bicycle.ChangeGear(2);

        Console.WriteLine($"The bicycle's owner is {bicycle.Owner.Name}, who is {bicycle.Owner.Age}");
        Console.WriteLine($"The bicycle is in gear {bicycle.CurrentGear}");
    }
}