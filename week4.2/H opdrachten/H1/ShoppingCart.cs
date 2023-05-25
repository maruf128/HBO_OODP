
public class ShoppingCart
{
    public List<GroupedShopItem> Groceries;
    public ShoppingCart()
    {
        Groceries = new List<GroupedShopItem>();
    }
    public void AddItem(ShopItem product)
    {
        // zoek het eerst en voeg het dan pas toe op basis van of het bestaat of niet bestaat
        GroupedShopItem groupedProduct = FindItem(product);

        if (groupedProduct != null)
        {
            // aka hij bestaat al, voeg dan 1 toe
            groupedProduct.Quantity++;
        }
        else
        {
            // anders voeg je een nieuwe item toe
            groupedProduct = new GroupedShopItem(product);

            // en voeg het dan toe aan het lijstje
            Groceries.Add(groupedProduct);
        }
    }
    // overload method met extra int
    public void AddItem(ShopItem product, int extra)
    {
        int howmany = extra;
        // zoek het eerst en voeg het dan pas toe op basis van of het bestaat of niet bestaat
        GroupedShopItem groupedProduct = FindItem(product);

        if (groupedProduct != null)
        {
            // aka hij bestaat al, voeg dat nu hoeveel items meegegeven is
            groupedProduct.Quantity += howmany;
        }
        else
        {
            // anders voeg je een nieuwe item toe
            groupedProduct = new GroupedShopItem(product);

            // en voeg het dan toe aan het lijstje
            Groceries.Add(groupedProduct);
        }
    }

    public GroupedShopItem FindItem(ShopItem product)
    {
        // voor iedere item in de lijst
        foreach (GroupedShopItem item in Groceries)
        {
            if (item.Item.ID == product.ID)
            {
                // return de item
                return item;
            }
        }

        return null; // wnr niks gelijk is
    }

    public string Contents()
    {
        string result = "";
        foreach (GroupedShopItem item in Groceries)
        {
            result += $"{item.Item.Name} x {item.Quantity}\n";
        }
        return result;
    }
    public decimal TotalPrice()
    {
        // maak de variable voor aal het geld
        decimal totaal = 0m;

        // voor iedere item
        foreach (GroupedShopItem item in Groceries)
        {
            // pak de prijs en doe aantal het keer en dan weet je van de betrefende product hoeveel het is
            totaal += (decimal)item.Item.Price * item.Quantity; // force decimaal ipv double
        }

        return totaal;
    }

}


