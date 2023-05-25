public interface IHasID
{
    int ID { get; set; }
}
public static class Library
{
    public static List<Book> Books = new();
    public static List<Customer> Customers = new();
    public static T FindByID<T>(List<T> list, int id) where T : IHasID
    {
        foreach (T item in list)
        {
            if (item.ID == id)
            {
                return item;
            }
        }
        return default(T);
    }
}