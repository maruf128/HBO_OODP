class Car
{
    public const int NumberOfWheels = 4;
    public string Color;

    public Car(string color)
    {
        Color = color;
    }

    public void Paint(string color) => Color = color;

    public string Info() =>
        $"My color is currently {Color}, but that may change. But I will always have {NumberOfWheels} wheels.";
}
class Program
{
    public static void Main()
    {
        var car = new Car("Yellow");
        Console.WriteLine(car.Info());
    }
}