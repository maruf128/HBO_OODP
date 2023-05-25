using System;

namespace Boekcollectie
{
    class Program
    {
        static void Main(string[] args)
        {

            // maak eerst een nieuwe book collectie
            BookCollection bookCollection = new BookCollection();

            // laat dan de json gegevens in en die worden dan omgezet via die functie's
            bookCollection.LoadBooksFromJson("books.json");

            // hiermee kan je bepalen of de q case is aangeklikt
            bool runnen = true;
            while (runnen)
            {
                Console.WriteLine("");// lege regel om het lees baar te houden
                Console.WriteLine("Book Collection:");
                foreach (var book in bookCollection.GetBooks())
                {
                    Console.WriteLine($"{book.Index}. {book.Title} by {book.Author} ({book.PublicationYear})");
                }
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("+: add a new book");
                Console.WriteLine("-: remove a book");
                Console.WriteLine("A number: see information on this book");
                Console.WriteLine("q: quit");

                // Read user input
                string input = Console.ReadLine().Trim().ToLower();
                switch (input)
                {
                    case "+":
                        Console.WriteLine("Enter the title of the book:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the author of the book:");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the publication year of the book:");
                        int year;
                        if (int.TryParse(Console.ReadLine(), out year))
                        {
                            // dan gebeurt er niks wnr het wel een nummer is
                        }
                        else
                        {
                            // The input is not a valid integer
                            Console.WriteLine("Year is not in a valid format");
                            break;
                        }
                        Book book = new Book(title, author, year);
                        bookCollection.AddBook(book);
                        break;
                    case "-":
                        Console.WriteLine("Enter the index of the book you want to remove:");
                        // indien het een nummer is
                        bool if_nummer = int.TryParse(Console.ReadLine(), out int index);
                        if (if_nummer)
                        {
                            Book bookToRemove = bookCollection.GetBook(index);
                            if (bookToRemove != null)
                            {
                                bookCollection.RemoveBook(bookToRemove);
                            }
                            else
                            {
                                Console.WriteLine($"Book does not exist.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Not an index.");
                        }
                        break;
                    case "q":
                        runnen = false;
                        break;
                    case "s":
                        Console.WriteLine("Enter the file path to save the books:");
                        string saveFilePath = Console.ReadLine();
                        try
                        {
                            bookCollection.SaveBooksToJson(saveFilePath);
                            Console.WriteLine($"Books saved to {saveFilePath}.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error saving books: {ex.Message}");
                        }
                        break;

                    default:
                        if (char.IsDigit(input[0]))
                        {
                            int bookIndex;
                            if (int.TryParse(input, out bookIndex))
                            {
                                Book bookToDisplay = bookCollection.GetBook(bookIndex);
                                if (bookToDisplay != null)
                                {
                                    Console.WriteLine($"Title: {bookToDisplay.Title}");
                                    Console.WriteLine($"Author: {bookToDisplay.Author}");
                                    Console.WriteLine($"Publication Year: {bookToDisplay.PublicationYear}");
                                }
                                else
                                {
                                    Console.WriteLine($"Book does not exist.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid input: {input}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid choice.");
                        }
                        break;
                }
            }
        }
    }
}