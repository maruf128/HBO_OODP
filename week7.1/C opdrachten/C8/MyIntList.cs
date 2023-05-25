public class MyIntList : MyGenericList<int> // zodra je weet met welke value je gaat werken kan je het in een child class aan geven ipv een letter
{
    public MyIntList(List<int> elems) : base(elems)
    {

    }
    public override int Combine()
    {
        int totaal = 0;
        foreach (int i in Elems)
        {
            totaal += i;
        }
        return totaal;
    }
}