class Program
{
    public static void Main()
    {
        var products = Factory.Produce("Tooth Paste", 5, 2.0);// zet ipv 2 een 2.0 sinds de 2 een double hoort te zijn
        double revenue = SellProducts(products);
        Console.WriteLine($"Revenue from selling: {revenue}");
    }

    public static double SellProducts(List<Product> products)
    {
        double total = 0;
        foreach (Product product in products)
            total += product.Price;
        return total;
    }
}