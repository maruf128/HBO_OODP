public class Triple<T1, T2, T3> : Pair<T1, T2> // wanneer je hem inherit noem het ook in de nieuwe class aan
{
    public T3 Trd { get; set; } // property

    public Triple(T1 value1, T2 value2, T3 value3) : base(value1, value2)
    {
        Trd = value3;
    }
}