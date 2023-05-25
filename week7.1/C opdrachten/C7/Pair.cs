public class Pair<T1, T2>
{
    public T1 Fst { get; set; } // property
    public T2 Snd { get; set; } // property

    public Pair(T1 value1, T2 value2)
    {
        Fst = value1;
        Snd = value2;
    }
}