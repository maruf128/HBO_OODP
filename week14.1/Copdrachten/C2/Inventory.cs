public class Inventory
{
    Dictionary<string, Product> _products;

    public Inventory()
    {
        _products = new Dictionary<string, Product>();
    }
    public void AddProduct(string naam, double prijs, int aantal)
    {
        // maak eerst de nieuwe object aan
        Product item = new Product(naam, prijs, aantal);
        // voeg de nieuwe item toe aan de dictionary
        _products.Add(item.Name, item);
    }
    public void AddProduct(string naam, double prijs)
    {
        int aantal = 0;
        // maak eerst de nieuwe object aan
        Product item = new Product(naam, prijs, aantal);
        // voeg de nieuwe item toe aan de dictionary
        _products.Add(item.Name, item);
    }
    public void RemoveProduct(string naam)
    {
        // item verwijderen
        _products.Remove(naam);
    }

    public Product GetProduct(string naam)
    {
        foreach (KeyValuePair<string, Product> item in _products)
        {
            if (item.Key == naam)
            {
                // prodcut gevonden
                return item.Value;
            }
        }
        return null;
    }

    public string GetInventorySummary()
    {
        // bekijk eerst hoeveel producten je hebt
        int TotAantal = 0;
        double TotPrijs = 0;
        foreach (KeyValuePair<string, Product> product in _products)
        {
            // voor iedere item maak je een nieuwe object aan
            Product item = product.Value;
            // voeg de aantal toe
            TotAantal += item.Quantity;
            // voor het geval er meerdere items zijn / maar dan weet je nu de prijs
            double berekening = item.Quantity * item.Price;
            TotPrijs += berekening;
        }
        // nu uit de for each heb je alle items prijzen
        string gegevens = $"Total products: {TotAantal}\n";
        gegevens += $"Total value: ${TotPrijs}\n";
        return gegevens;
    }
}