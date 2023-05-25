public class ListWrapper<T>
{
    private List<T> _myList; // zet de t in de list 

    public ListWrapper()
    {
        _myList = new List<T>();
    }

    public void Add(T gegeven)
    {
        _myList.Add(gegeven);
    }
    public T Get(int getal)
    {
        return _myList[getal];
    }
    public int Count
    {
        get { return _myList.Count; }
    }
}