using System.Collections.Generic;

public class Book
{
    // book waarin je de id en title vast stelt
    public int ID;
    public string Title;

    // de constuctor zodat je de gegevens kan omzetten
    public Book(int id, string title)
    {
        ID = id;
        Title = title;
    }
    public string Info()
    {
        return $"ID = {ID}, Title = {Title}";
    }
}
