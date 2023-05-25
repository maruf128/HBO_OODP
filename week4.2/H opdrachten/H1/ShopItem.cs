public class ShopItem
{
    public string ID;
    public string Name;
    public double Price;

    public ShopItem(string index, string naam, double prijs)
    {
        ID = index;
        Name = naam;
        Price = prijs;
    }
    // overload wnr geen naam
    public ShopItem(string index, double prijs)
    {
        ID = index;
        Name = "Unknown"; // geef het unknown
        Price = prijs;
    }
}
