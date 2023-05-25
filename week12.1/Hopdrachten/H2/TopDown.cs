public static class TopDown
{
    public static void Display<T>(Item<T> item) => Display(item, "");
    public static void Display<T>(Item<T> item, string format)
    {
        if (item == null)
        {
            Console.WriteLine("None");
            return;
        }

        Console.WriteLine($"{format} {item.Value}");
        if (item.SubItems == null)
            return;

        item.SubItems.ForEach(sub => Display(sub, format + "---"));
    }

    public static Item<T> Find<T>(Item<T> item, T key)
    {
        if (item == null)
        {
            return null; // indien niks return gelijk 0
        }

        if (EqualityComparer<T>.Default.Equals(item.Value, key))
        {
            return item; // indien het gelijk is return de item
        }

        if (item.SubItems == null)
        {
            return null; // indien de subitems 0 zijn return  null
        }

        foreach (var subItem in item.SubItems) // anders zijn in de subitems
        {
            var foundItem = Find(subItem, key); // zoek het en geen subitem mee
            if (foundItem != null) // indien het niet gelijk is aan null return found item en doe je in een for each loop
            {
                return foundItem;
            }
        }

        return null;
    }

}