class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;

    public void Move(int getal)
    {
        Console.WriteLine($"Drove {getal} kms");
        Mileage = Mileage + getal;
        Console.WriteLine($"Mileage: {Mileage} kms");
    }
}