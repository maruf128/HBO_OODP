public class Book
{
    public int ID;
    public string Title;

    // wnr 1 parameter is meegegeven
    public Book(int index)
    {
        ID = index;
        Title = "Title unknown";
    }
    // anders met 2
    public Book(int index, string titel)
    {
        ID = index;
        Title = titel;
    }
    public string Info()
    {
        // return de info
        return $"ID = {ID}, Title = {Title}";
    }
}