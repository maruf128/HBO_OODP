// namespace Boekcollectie
// {
//     [TestClass]
//     public class BookCollectionTest
//     {
//         private BookCollection _bookCollection;

//         /*
//             This method runs before every test. Optionally use this to make sure every test starts with an empty state.
//         */
//         [TestInitialize]
//         public void Setup()
//         {
//             // Create a new BookCollection instance
//             _bookCollection = new BookCollection();
//         }

//         [TestMethod]
//         public void Add_Book()
//         {
//             // Assert that the count of books equals zero
//             Assert.AreEqual(0, _bookCollection.Count);

//             // Add a book
//             var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
//             _bookCollection.AddBook(book);

//             // Assert that the count of books equals one
//             Assert.AreEqual(1, _bookCollection.Count);
//         }

//         [TestMethod]
//         public void Remove_Book()
//         {
//             // Add a book
//             var book = new Book("The Catcher in the Rye", "J.D. Salinger", 1951);
//             _bookCollection.AddBook(book);

//             // Remove the book
//             _bookCollection.RemoveBook(book);

//             // Assert that the count of books equals zero
//             Assert.AreEqual(0, _bookCollection.Count);
//         }

//         [TestMethod]
//         public void Remove_AllBooks()
//         {
//             // Add three books
//             var book1 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
//             var book2 = new Book("1984", "George Orwell", 1949);
//             var book3 = new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954);
//             _bookCollection.AddBook(book1);
//             _bookCollection.AddBook(book2);
//             _bookCollection.AddBook(book3);

//             // Remove all books
//             _bookCollection.RemoveAllBooks();

//             // Assert that the count of books equals zero
//             Assert.AreEqual(0, _bookCollection.Count);
//         }

//         [TestMethod]
//         public void Get_Books()
//         {
//             // Add three books
//             var book1 = new Book("Pride and Prejudice", "Jane Austen", 1813);
//             var book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
//             var book3 = new Book("Beloved", "Toni Morrison", 1987);
//             _bookCollection.AddBook(book1);
//             _bookCollection.AddBook(book2);
//             _bookCollection.AddBook(book3);

//             // Assert that the count of books equals three
//             Assert.AreEqual(3, _bookCollection.Count);
//         }

//         [TestMethod]
//         public void Get_Book()
//         {
//             // Add three books
//             var book1 = new Book("The Adventures of Huckleberry Finn", "Mark Twain", 1884);
//             var book2 = new Book("The Old Man and the Sea", "Ernest Hemingway", 1952);
//             var book3 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951);
//             _bookCollection.AddBook(book1);
//             _bookCollection.AddBook(book2);
//             _bookCollection.AddBook(book3);

//             // Assert that the title of an added book matches the expected title
//             Assert.AreEqual("The Old Man and the Sea", _bookCollection.GetBook("Ernest Hemingway").Title);
//             Assert.AreEqual("The Adventures of Huckleberry Finn", _bookCollection.GetBook("Mark Twain").Title);
//         }

//         [TestMethod]
//         public void Set_Books()
//         {
//             // Create a list with three books
//             List<Book> books = new List<Book>();
//             books.Add(new Book("Book 1", "Author 1", 2000));
//             books.Add(new Book("Book 2", "Author 2", 2005));
//             books.Add(new Book("Book 3", "Author 3", 2010));

//             // Set the books
//             _bookCollection.SetBooks(books);

//             // Assert.IsTrue: assert that the count of books equals three    
//             Assert.AreEqual(3, _bookCollection.GetBooks().Count);

//             // Assert.AreEqual: assert (twice) that the title of an added book matches the expected title)
//             Assert.AreEqual("Book 1", _bookCollection.GetBook("Book 1").Title);
//             Assert.AreEqual("Book 2", _bookCollection.GetBook("Book 2").Title);
//         }
//     }
// }