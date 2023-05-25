public class Library
{
    public List<Book> Books;

    public Library()
    {
        // indien niks word megegeven maak je een nieuwe lijst voor de list
        Books = new List<Book>();
    }

    public Library(List<Book> books)
    {
        // anders als er wel is verander je het
        this.Books = books; // this wijst de books van deze class aan
    }

    // add methods:
    public void AddBook(Book boek) // met een book instance
    {
        Books.Add(boek);
    }
    public void AddBook(int index, string naam) // met titel en id
    {
        // maak met de gegevens een nieuwe boek aan
        Book book = new Book(index, naam);
        // en roep add book op
        AddBook(book);
    }

    // find methods:
    public Book FindBook(int index) // met int
    {
        foreach (Book book in Books)
        {
            // zoek voor iedere boek naar de id
            if (book.ID == index)
            {
                // return de boek
                return book;
            }
        }
        // anders bestaat hij niet
        return null;
    }

    public Book FindBook(string text)
    {
        // kijk of de gegeven string een id kan zijn return dan de find boek met id
        int index;
        if (int.TryParse(text, out index))
        {
            return FindBook(index);
        }
        else
        {
            // anders scrijf je dat het geen id is
            Console.WriteLine($"ID = {text}: not a valid book ID. Input string was not in a correct format.");
            //ID = Five: not a valid book ID. Input string was not in a correct format. codegrade wou dit >:(
            return null;
        }
    }


}