using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace Boekcollectie
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        // jsonignore negeert het terwijl je het upload naar de lijst
        [JsonIgnore] public int Index { get; set; } // add Index property (:D zelf bedacht echt trots hierop)

        private static int lastAssignedIndex = 0; // hiermee hou je de laaste index in de gaten

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            PublicationYear = year;
            Index = ++lastAssignedIndex; // hier geef je iedere keer ++ voor een boek
        }
    }


    public class BookCollection
    {
        // maak een list aan met books werkende met de test
        public List<Book> _books;

        public BookCollection()
        {
            // constructor
            _books = new List<Book>();
        }

        public int Count
        {
            // tell hoeveel boeken er zijn
            get { return _books.Count; }
        }

        public void AddBook(Book book)
        {
            // krijg de index van de book voor hem
            int lastIndex = _books.Count - 1;

            // zet de index eentje hoger dan die van daarvoor
            if (lastIndex >= 0)
            {
                // indeien het 0 of groter is dan 0 maak de index dan 1 groter dan de book ervoor
                book.Index = _books[lastIndex].Index + 1;
            }
            else
            {
                // anders als er geen boeken zijn zet de index 1
                book.Index = 1;
            }
            // en voeg hem dan pas toe
            _books.Add(book);
            // sla de boeken nu op die bestaan
            SaveBooksToJson("books.json");
        }


        public bool RemoveBook(Book book)
        {
            // hiermee verwijder je de boek
            int index = _books.IndexOf(book);
            // hiermee zorg je dat de id goed blijft lopen van 1 tot laatste boek zoals codegrade wilt
            if (index >= 0)
            {
                _books.Remove(book);
                for (int i = index; i < _books.Count; i++)
                {
                    _books[i].Index = i + 1;
                }
                // sla de boeken nu op die bestaan
                SaveBooksToJson("books.json");
                return true;
            }
            else
            {
                return false;
            }
        }


        public void RemoveAllBooks()
        {
            // verwijder alle boeken van de list
            _books.Clear();
        }

        public List<Book> GetBooks()
        {
            // krijg de boek
            return _books;
        }

        public Book GetBook(int index)
        {
            // krijg de boek based on de index
            return _books.Find(book => book.Index == index);
        }
        public Book GetBook(string auteur)
        {
            // krijg de boek based on de index
            return _books.Find(book => book.Author == auteur);
        }

        public void SetBooks(List<Book> books)
        {
            // set een boek
            _books = books;
        }

        public void LoadBooksFromJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                _books = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            catch (FileNotFoundException error)
            {
                // ga veder wnr er geen file is
                _books = new List<Book>();
            }
            catch (JsonReaderException ex)
            {
                // wnr er iets raars mee is
                _books = new List<Book>();
            }
        }


        public void SaveBooksToJson(string filePath)
        {
            // maak een nieuwe lijst van de boeken die bestaan
            List<Book> booksToSave = new List<Book>(_books);
            // zorg dat codegrade hem nu wel accepteert
            string json = JsonConvert.SerializeObject(booksToSave, new JsonSerializerSettings { Formatting = Formatting.None });
            // en upload het naar de json file
            using (StreamWriter w = new StreamWriter(filePath))
            {
                w.Write(json);
            }
        }


    }
}