public class Shop
{
    private List<string> _inventory = new(); // private

    public Shop(List<string> items)
    {
        _inventory.AddRange(items);
    }

    public string Buy(string item) // word aangeroepen
    {
        return HaveInInventory(item) ? item : "Not in inventory";
    }

    public bool HaveInInventory(string item) => _inventory.Contains(item); // word aangeroepen
}