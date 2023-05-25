public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Product(string naam, double prijs, int aantal)
    {
        Name = naam;
        Price = prijs;
        Quantity = aantal;
    }
    public override string ToString()
    {
        return $"{Name}, Price: ${Price}, Quantity: {Quantity}";
    }
}