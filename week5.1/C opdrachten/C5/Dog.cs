public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        base.Sound = "Woof!";
    }

    public void Fetch()
    {
        string text = $"{Name} fetches the stick";
        Console.WriteLine(text);
    }
}