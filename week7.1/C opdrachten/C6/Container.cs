public class Container<C>
{
    public C Value { get; set; } // property

    public Container(C gegeven)
    {
        Value = gegeven;
    }

    public void ResetValue()
    {
        Value = default;
    }
}