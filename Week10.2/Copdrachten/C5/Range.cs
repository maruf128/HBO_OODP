public class Range
{
    public int Start { get; }
    public int End { get; }
    public int Step { get; }

    public Range(int begin, int eind, int stap)
    {
        Start = begin;
        End = eind;
        Step = stap;
    }
    public IEnumerable<int> Next()
    {
        int current = Start - Step; // zorg ervoor dat je plus kan gaan doen
        while ((current += Step) < End)
        {
            yield return current;
        }
    }
}