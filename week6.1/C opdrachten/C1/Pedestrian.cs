public class Pedestrian : Person, ICommute
{
    public Pedestrian(string name) : base(name) { }
    public void Move(int getal)
    {
        Console.WriteLine($"Walked {getal} kms");
    }
}