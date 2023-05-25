public abstract class MyGenericList<T>
{
    public List<T> Elems;
    protected MyGenericList(List<T> elems)
    {
        Elems = elems; // zelf aangepast ik hou niet van => en op 1 line
    }
    public abstract T Combine();
}