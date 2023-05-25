public class Tire
{
    public string Brand { get; }
    public int Durability { get; set; } = 5; // read write

    public Tire(string merk)
    {
        Brand = merk;
    }
}