using System.Collections.Generic;

public class Library
{
    public List<Book> Books;
    public int MaxSize;

    public Library(int maximaal)
    {
        // constuctor
        Books = new List<Book>();
        MaxSize = maximaal;
    }

    public bool AddBook(int id, string titel)
    {
        // boek een book to met behulp van de class
        if (Books.Count >= MaxSize) // aka het zit vol
        {
            return false;
        }
        else
        {
            Book book = new Book(id, titel);
            Books.Add(book);
            return true;
        }
    }

    public Book FindBook(int id)
    {
        // vind boek 
        foreach (var book in Books)
        {
            if (book.ID == id)
            {
                return book;
            }
        }
        return null;
    }
    public void ModifyBook(int id, string titel)
    {
        var book = FindBook(id); // kijk eerst of boek er is en krijg gegevens terug

        if (book != null)
        {
            book.Title = titel; // Update the book's title
        }
    }
}