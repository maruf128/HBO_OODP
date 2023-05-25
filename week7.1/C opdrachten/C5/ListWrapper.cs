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
    public int HighestCount<U>(ListWrapper<U> list2) // geef het een nieuwe letter om het goed te houden
    {
        int count1 = Count;
        int count2 = list2.Count;
        if (count1 > count2)
        {
            return count1;
        }
        else if (count2 > count1)
        {
            return count2;
        }
        else
        {
            return count1;
        }
    }
}