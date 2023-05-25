public class Item<T>
{
    public T Value;
    public List<Item<T>>? SubItems;

    public Item(T value, List<Item<T>>? sub = null)
    {
        Value = value;
        SubItems = sub;
    }
}