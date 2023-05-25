public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        base.Sound = "Meow!";
    }

    public void Climb()
    {
        string text = $"{Name} climbs the curtains";
        Console.WriteLine(text);
    }
}