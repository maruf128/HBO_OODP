public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    //Implement the IComparable interface method
    public int CompareTo(Book vergelijking)
    {
        if (vergelijking == null) return 1; // zodra de other object leeg is return 0

        //kijk eerst naar jaar
        int jaarvergelijking = this.Year.CompareTo(vergelijking.Year);
        if (jaarvergelijking != 0)
        {
            return jaarvergelijking;
        }

        //indien hij niet gereturned is kijk op basis van auteur
        int auteurvergelkijking = this.Author.CompareTo(vergelijking.Author);
        if (auteurvergelkijking != 0)
        {
            return auteurvergelkijking;
        }

        //If age is also the same, compare by name
        return this.Title.CompareTo(vergelijking.Title);
    }
}