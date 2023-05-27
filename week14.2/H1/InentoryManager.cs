using Newtonsoft.Json;
using System.Linq;
public static class InventoryManager
{
    public static List<Plant> ReadInventory(string dataset)
    {
        string jsonString = File.ReadAllText(dataset);
        return JsonConvert.DeserializeObject<List<Plant>>(jsonString)!;
    }
    public static List<Plant> DetectLowInventory(List<Plant> inventory)
    {
        // order het
        var query = inventory.OrderBy(item => item);
        // maak de where
        List<Plant> below_5 = query.Where(item => item.Stock < 5).ToList();
        return below_5;
    }
    public static List<Plant> SearchByCategory(List<Plant> inventory, string category)
    {
        IEnumerable<Plant> query =
            from categorie in inventory
            where categorie.Category == category
            select categorie;
        List<Plant> planten = query.ToList();
        return planten;
    }
    public static List<Plant> LastSoldItems(List<Plant> inventory)
    {
        // vind de laatste datum eerst
        DateOnly last_sold = inventory.Max(plant => plant.LastSold);

        IEnumerable<Plant> query =
            from categorie in inventory
            where categorie.LastSold == last_sold
            select categorie;
        List<Plant> planten = query.ToList();
        return planten;
    }
    public static List<Plant> PotentialRemoval(List<Plant> inventory)
    {
        // Get the current date
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

        List<Plant> result = inventory.Where(plant =>
        {
            int monthsDiff = CalculateMonthsDifference(plant.LastSold, currentDate);
            return monthsDiff > 10 && plant.Stock >= 10; // return only if the plant has a difference of more than 10 months
        }).ToList();

        return result;
    }

    private static int CalculateMonthsDifference(DateOnly startDate, DateOnly endDate)
    {
        int monthsDiff = (endDate.Year - startDate.Year) * 12 + (endDate.Month - startDate.Month);
        return monthsDiff;
    }
}