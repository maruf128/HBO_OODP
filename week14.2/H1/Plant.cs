using System.Globalization;
using System.Linq;
public class Plant : IComparable<Plant>
{
    public string Name { get; set; }
    public string Category { get; set; }

    private int _stock;
    public int Stock
    {
        get
        {
            return _stock;
        }
    }
    public DateOnly LastSold;

    public Plant(string name, string category, int stock, string lastSold)
    {
        Name = name;
        Category = category;
        _stock = stock;
        LastSold = DateOnly.ParseExact(lastSold, "dd-MM-yyyy", CultureInfo.InvariantCulture);
    }

    public int CompareTo(Plant other)
    {
        return other == null ? 1 : Stock.CompareTo(other.Stock);
    }
    public int Sell(int amount)
    {
        int verkocht = Math.Min(amount, Stock); // min elkaar
        // zet de stock goed
        _stock -= verkocht;
        LastSold = DateOnly.FromDateTime(DateTime.Now);
        return verkocht;
    }
}