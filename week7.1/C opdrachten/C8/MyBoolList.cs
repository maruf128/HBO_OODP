public class MyBoolList : MyGenericList<bool> // zodra je weet met welke value je gaat werken kan je het in een child class aan geven ipv een letter
{
    public MyBoolList(List<bool> elems) : base(elems)
    {

    }
    public override bool Combine()
    {
        foreach (bool value in Elems)
        {
            if (value == false)
            {
                return false;
            }
        }
        return true;
    }
}